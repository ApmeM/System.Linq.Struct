// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct RangeEnumerator
        : IRefEnumerator<int>
    {
        private readonly int end;

        public RangeEnumerator(int start, int count)
        {
            this.Current = start - 1;
            this.end = start + count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            this.Current++;
            return this.Current < this.end;
        }

        public int Current { get; private set; }
    }
}