// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Prepend<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        private TEnumerator prev;
        private readonly T toPrepend;
        private bool theFirstAlreadyYielded;
        public Prepend(TEnumerator prev, T toPrepend)
        {
            this.prev = prev;
            this.theFirstAlreadyYielded = false;
            this.toPrepend = toPrepend;
            this.Current = default(T);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (this.theFirstAlreadyYielded)
            {
                if (this.prev.MoveNext())
                {
                    this.Current = this.prev.Current;
                    return true;
                }
                return false;
            }
            this.Current = this.toPrepend;
            this.theFirstAlreadyYielded = true;
            return true;
        }

        public T Current { get; private set; }
    }
}