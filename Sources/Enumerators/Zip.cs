// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct Zip<T1, TEnumerator1, T2, TEnumerator2>
        : IRefEnumerator<(T1, T2)>
        where TEnumerator1 : IRefEnumerator<T1>
        where TEnumerator2 : IRefEnumerator<T2>
    {
        private TEnumerator1 en1;
        private TEnumerator2 en2;

        public Zip(TEnumerator1 en1, RefLinqEnumerable<T2, TEnumerator2> en2)
        {
            this.en1 = en1;
            this.en2 = en2.enumerator;
            this.Current = default;
        }

        public (T1, T2) Current { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            var res1 = this.en1.MoveNext();
            var res2 = this.en2.MoveNext();
            if (!res1 && !res2)
                return false;
            if (res1 && res2)
            {
                this.Current = (this.en1.Current, this.en2.Current);
                return true;
            }
            ThrowInvalid();
            return default;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void ThrowInvalid()
            => throw new InvalidOperationException("Collections should have the same size");
    }
}