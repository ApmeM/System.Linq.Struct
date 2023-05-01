// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Skip<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        private TEnumerator en;
        private int toSkip;
        public Skip(TEnumerator en, int toSkip)
        {
            this.en = en;
            this.toSkip = toSkip;
            this.Current = default(T);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (this.toSkip is 0)
            {
                var res = en.MoveNext();
                if (res)
                    Current = this.en.Current;
                return res;
            }
            bool theLastMovedNext;
            while ((theLastMovedNext = this.en.MoveNext()) && this.toSkip > 0)
            {
                this.toSkip--;
            }
            if (!theLastMovedNext)
                return false;
            this.Current = this.en.Current;
            return true;
        }

        public T Current { get; private set; }
    }
}