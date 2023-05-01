// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct OfType<T, TEnumerator, U>
        : IRefEnumerator<U>
        where TEnumerator : IRefEnumerator<T>
    {
        public OfType(TEnumerator prev)
        {
            this.prev = prev;
            this.Current = default(U);
        }
        private TEnumerator prev;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
        tryAgain:
            if (!prev.MoveNext())
                return false;
            if (!(prev.Current is U uCurrent))
                goto tryAgain;

            this.Current = uCurrent;
            return true;
        }

        public U Current { get; private set; }
    }
}