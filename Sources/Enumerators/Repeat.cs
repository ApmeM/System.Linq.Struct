// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct Repeat<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        private TEnumerator first;
        private TEnumerator cur;
        private int count;

        public Repeat(TEnumerator first, int count)
        {
            this.first = first;
            this.cur = this.first;
            this.count = count;
            Current = default(T);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
        start:
            if (count == 0)
            {
                return false;
            }

            if (this.cur.MoveNext())
            {
                Current = this.cur.Current;
                return true;
            }
            count--;
            this.cur = this.first;
            goto start;
        }

        public T Current { get; private set; }
    }
}