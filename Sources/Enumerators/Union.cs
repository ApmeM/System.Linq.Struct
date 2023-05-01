// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Union<T, TEnumerator1, TEnumerator2>
        : IRefEnumerator<T>
        where TEnumerator1 : IRefEnumerator<T>
        where TEnumerator2 : IRefEnumerator<T>
    {
        private TEnumerator1 first;
        private TEnumerator2 second;
        private bool firstIsOver;
        private readonly HashSet<T> sortList;
        private bool initialized;

        public Union(TEnumerator1 first, RefLinqEnumerable<T, TEnumerator2> second)
        {
            this.first = first;
            this.second = second.enumerator;
            this.firstIsOver = false;
            this.Current = default(T);
            this.sortList = new HashSet<T>();
            this.initialized = false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!this.initialized)
            {
                this.initialized = true;
                this.sortList.Clear();
            }

            if (this.firstIsOver)
            {
            tryAgain2:
                if (!this.second.MoveNext())
                    return false;
                if (this.sortList.Contains(this.second.Current))
                    goto tryAgain2;
                this.sortList.Add(this.second.Current);
                this.Current = this.second.Current;
                return true;
            }

        tryAgain1:
            if (!this.first.MoveNext())
            {
                this.firstIsOver = true;
                return MoveNext();
            }
            if (this.sortList.Contains(this.first.Current))
                goto tryAgain1;
            this.sortList.Add(this.first.Current);
            this.Current = this.first.Current;
            return true;
        }

        public T Current { get; private set; }
    }
}