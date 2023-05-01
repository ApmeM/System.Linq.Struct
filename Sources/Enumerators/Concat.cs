// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Concat<T, TEnumerator1, TEnumerator2>
        : IRefEnumerator<T>
        where TEnumerator1 : IRefEnumerator<T>
        where TEnumerator2 : IRefEnumerator<T>
    {
        private TEnumerator1 first;
        private TEnumerator2 second;
        private bool firstIsOver;

        public Concat(TEnumerator1 first, RefLinqEnumerable<T, TEnumerator2> second)
        {
            this.first = first;
            this.second = second.enumerator;
            this.firstIsOver = false;
            this.Current = default(T);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (this.firstIsOver)
            {
                if (this.second.MoveNext())
                {
                    this.Current = this.second.Current;
                    return true;
                }
                return false;
            }
            if (this.first.MoveNext())
            {
                this.Current = this.first.Current;
                return true;
            }
            else
            {
                this.firstIsOver = true;
                return MoveNext();
            }
        }

        public T Current { get; private set; }
    }
}