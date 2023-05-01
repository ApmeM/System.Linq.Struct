// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Cast<T, TEnumerator, U>
        : IRefEnumerator<U>
        where TEnumerator : IRefEnumerator<T>
    {
        public Cast(TEnumerator prev)
        {
            this.prev = prev;
            this.Current = default(U);
        }
        private TEnumerator prev;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!this.prev.MoveNext())
                return false;
            this.Current = CastMethodGenerator<T, U>.cast(this.prev.Current);
            return true;
        }

        public U Current { get; private set; }
    }
}