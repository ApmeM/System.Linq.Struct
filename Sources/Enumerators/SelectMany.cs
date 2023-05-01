// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct SelectMany<T, TEnumerator, TEnumeratorOfEnumerators>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
        where TEnumeratorOfEnumerators : IRefEnumerator<RefLinqEnumerable<T, TEnumerator>>
    {
        private TEnumeratorOfEnumerators en;
        private TEnumerator currEn;
        private bool iterStarted;

        public SelectMany(TEnumeratorOfEnumerators en)
        {
            this.en = en;
            this.currEn = default(TEnumerator);
            this.iterStarted = false;
            this.Current = default(T);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
        begin:
            if (!this.iterStarted)
            {
                this.iterStarted = true;
                if (this.en.MoveNext())
                {
                    this.currEn = this.en.Current.enumerator;
                    goto begin;
                }
                return false;
            }
            if (this.currEn.MoveNext())
            {
                this.Current = this.currEn.Current;
                return true;
            }
            this.iterStarted = false;
            goto begin;
        }

        public T Current { get; private set; }
    }
}