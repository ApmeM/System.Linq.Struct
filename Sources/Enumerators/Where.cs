// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct Where<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        public Where(TEnumerator prev, Func<T, bool> map)
        {
            this.prev = prev;
            this.map = map;
            this.Current = default(T);
        }

        private TEnumerator prev;
        private readonly Func<T, bool> map;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
        tryAgain:
            if (!this.prev.MoveNext())
                return false;
            if (!this.map.Invoke(this.prev.Current))
                goto tryAgain;
            this.Current = this.prev.Current;
            return true;
        }
        public T Current { get; private set; }
    }
}