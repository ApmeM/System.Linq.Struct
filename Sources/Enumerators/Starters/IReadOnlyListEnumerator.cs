// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct IReadOnlyListEnumerator<T> : IRefEnumerator<T>
    {
        private readonly IReadOnlyList<T> list;
        private int idx;

        public IReadOnlyListEnumerator(IReadOnlyList<T> list)
        {
            this.list = list;
            this.idx = -1;
            this.Current = default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            this.idx++;
            if (this.idx < this.list.Count)
            {
                this.Current = this.list[this.idx];
                return true;
            }
            return false;
        }

        public T Current { get; private set; }
    }
}