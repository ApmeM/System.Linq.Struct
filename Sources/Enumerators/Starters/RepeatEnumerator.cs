// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace System.Linq.Struct
{

    public struct RepeatEnumerator<T>
        : IRefEnumerator<T>
    {
        private int count;

        public RepeatEnumerator(T item, int count)
        {
            this.Current = item;
            this.count = count;
        }

        public bool MoveNext()
        {
            this.count--;
            return count >= 0;
        }

        public T Current{get; private set;}
    }
}