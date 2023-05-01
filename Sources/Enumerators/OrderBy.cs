// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct OrderBy<T, TEnumerator, TKey>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        internal OrderBy(TEnumerator prev, Func<T, TKey> keySelector)
        {
            this.prev = prev;
            this.keySelector = keySelector;
            this.idx = -1;
            this.Current = default(T);
            this.sortList = new List<T>();
            this.initialized = false;
            this.comparer = (a, b) => Comparer<TKey>.Default.Compare(keySelector(a), keySelector(b));
        }

        private TEnumerator prev;
        private readonly Func<T, TKey> keySelector;
        private readonly List<T> sortList;
        private int idx;
        private bool initialized;
        private Comparison<T> comparer;

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
                this.sortList.Sort(this.comparer);
            }

            this.idx++;
            if (this.idx >= this.sortList.Count)
                return false;
            this.Current = this.sortList[this.idx];
            return true;
        }
        
        public T Current { get; private set; }
    }
}