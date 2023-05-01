// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Distinct<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        internal Distinct(TEnumerator prev)
        {
            this.prev = prev;
            this.Current = default(T);
            this.sortList = new HashSet<T>();
            this.initialized = false;
        }

        private TEnumerator prev;
        private readonly HashSet<T> sortList;
        private bool initialized;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!initialized)
            {
                initialized = true;
                sortList.Clear();
            }

        tryAgain:
            if (!prev.MoveNext())
                return false;
            var key = prev.Current;
            if (this.sortList.Contains(key))
                goto tryAgain;
            this.sortList.Add(key);
            this.Current = prev.Current;
            return true;
        }
        public T Current { get; private set; }
    }
}