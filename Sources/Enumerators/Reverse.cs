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
            Current = default(T);
            sortList = new List<T>();
            initialized = false;
            idx=-1;
        }

        private TEnumerator prev;
        private readonly List<T> sortList;
        private bool initialized;
        private int idx;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!initialized)
            {
                initialized = true;
                sortList.Clear();
                while (prev.MoveNext())
                {
                    sortList.Add(prev.Current);
                }
                idx = sortList.Count;
            }

            idx--;
            if(idx < 0)
                return false;
            this.Current = sortList[idx];
            return true;
        }

        public T Current { get; private set; }

        public Reverse<T, TEnumerator> GetEnumerator() => this;
    }
}