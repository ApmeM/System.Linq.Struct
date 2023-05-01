// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct ArrayEnumerator<T> : IRefEnumerator<T>
    {
        private readonly T[] array;
        private int idx;

        public ArrayEnumerator(T[] array)
        {
            this.array = array;
            this.idx = -1;
            this.Current = default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            this.idx++;
            if (this.idx < this.array.Length)
            {
                this.Current = this.array[idx];
                return true;
            }
            return false;
        }

        public T Current { get; private set; }
    }
}