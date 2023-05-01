// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct DistinctBy<T, TEnumerator, TKey>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        internal DistinctBy(TEnumerator prev, Func<T, TKey> keySelector)
        {
            this.prev = prev;
            this.keySelector = keySelector;
            this.Current = default(T);
            this.sortList = new HashSet<TKey>();
            this.initialized = false;
        }

        private TEnumerator prev;
        private readonly Func<T, TKey> keySelector;
        private readonly HashSet<TKey> sortList;
        private bool initialized;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!this.initialized)
            {
                this.initialized = true;
                this.sortList.Clear();
            }

        tryAgain:
            if (!this.prev.MoveNext())
                return false;
            var key = this.keySelector.Invoke(this.prev.Current);
            if (this.sortList.Contains(key))
                goto tryAgain;
            this.sortList.Add(key);
            this.Current = this.prev.Current;
            return true;
        }
        public T Current { get; private set; }
    }
}