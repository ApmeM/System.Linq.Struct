// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct ArrayEnumerator<T> : IRefEnumerator<T>
    {
        private readonly T[] array;
        private int curr;

        public ArrayEnumerator(T[] array)
        {
            this.array = array;
            this.curr = -1;
            this.Current = default(T);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            this.curr++;
            if (this.curr < this.array.Length)
            {
                this.Current = this.array[curr];
                return true;
            }
            return false;
        }

        public T Current { get; private set; }
    }
}