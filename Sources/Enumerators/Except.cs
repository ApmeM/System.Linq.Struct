// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Except<T, TEnumerator1, TEnumerator2>
        : IRefEnumerator<T>
        where TEnumerator1 : IRefEnumerator<T>
        where TEnumerator2 : IRefEnumerator<T>
    {
        public Except(TEnumerator1 prev, RefLinqEnumerable<T, TEnumerator2> second)
        {
            this.prev = prev;
            this.second = second.enumerator;
            this.Current = default(T);
            this.initialized = false;
            this.sortList = new HashSet<T>();
        }

        private TEnumerator1 prev;
        private TEnumerator2 second;
        private bool initialized;
        private readonly HashSet<T> sortList;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!this.initialized)
            {
                this.initialized = true;
                this.sortList.Clear();
                while (second.MoveNext())
                {
                    this.sortList.Add(this.second.Current);
                }
            }

        tryAgain:
            if (!this.prev.MoveNext())
                return false;
            if (this.sortList.Contains(this.prev.Current))
                goto tryAgain;
            this.Current = this.prev.Current;
            return true;
        }
        
        public T Current { get; private set; }
    }
}