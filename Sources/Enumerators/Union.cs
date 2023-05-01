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
            firstIsOver = false;
            Current = default(T);
            this.sortList = new HashSet<T>();
            this.initialized = false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!initialized)
            {
                this.initialized = true;
                this.sortList.Clear();
            }

            if (firstIsOver)
            {
            tryAgain2:
                if (!second.MoveNext())
                    return false;
                if (this.sortList.Contains(second.Current))
                    goto tryAgain2;
                this.sortList.Add(second.Current);
                this.Current = second.Current;
                return true;
            }

        tryAgain1:
            if (!first.MoveNext())
            {
                firstIsOver = true;
                return MoveNext();
            }
            if (this.sortList.Contains(first.Current))
                goto tryAgain1;
            this.sortList.Add(first.Current);
            this.Current = first.Current;
            return true;
        }

        public T Current { get; private set; }
    }
}