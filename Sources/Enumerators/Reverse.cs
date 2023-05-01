// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Reverse<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        internal Reverse(TEnumerator prev)
        {
            this.prev = prev;
            this.Current = default(T);
            this.sortList = new List<T>();
            this.initialized = false;
            this.idx = -1;
        }

        private TEnumerator prev;
        private readonly List<T> sortList;
        private bool initialized;
        private int idx;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!this.initialized)
            {
                this.initialized = true;
                this.sortList.Clear();
                while (this.prev.MoveNext())
                {
                    this.sortList.Add(this.prev.Current);
                }
                this.idx = this.sortList.Count;
            }

            this.idx--;
            if (this.idx < 0)
                return false;
            this.Current = this.sortList[idx];
            return true;
        }

        public T Current { get; private set; }
    }
}