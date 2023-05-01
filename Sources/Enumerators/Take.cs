// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Take<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        private TEnumerator en;
        private int toTake;
        public Take(TEnumerator en, int toTake)
        {
            this.en = en;
            this.toTake = toTake;
            this.Current = default(T);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (this.toTake > 0 && this.en.MoveNext())
            {
                this.Current = this.en.Current;
                this.toTake--;
                return true;
            }
            return false;
        }

        public T Current { get; private set; }
    }
}