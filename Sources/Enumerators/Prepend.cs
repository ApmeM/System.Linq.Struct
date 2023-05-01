// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct Prepend<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        private TEnumerator prev;
        private readonly T toPrepend;
        private bool theFirstAlreadyYielded;
        public Prepend(TEnumerator prev, T toPrepend)
        {
            this.prev = prev;
            theFirstAlreadyYielded = false;
            this.toPrepend = toPrepend;
            Current = default(T);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (theFirstAlreadyYielded)
            {
                if (prev.MoveNext())
                {
                    Current = prev.Current;
                    return true;
                }
                return false;
            }
            Current = toPrepend;
            theFirstAlreadyYielded = true;
            return true;
        }

        public T Current { get; private set; }
    }
}