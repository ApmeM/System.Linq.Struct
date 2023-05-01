// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{

    public struct Append<T, TEnumerator>
        : IRefEnumerator<T>
        where TEnumerator : IRefEnumerator<T>
    {
        private TEnumerator prev;
        private readonly T toAppend;
        private bool theLastAlreadyYielded;
        public Append(TEnumerator prev, T toAppend)
        {
            this.prev = prev;
            this.theLastAlreadyYielded = false;
            this.toAppend = toAppend;
            this.Current = default(T);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (this.theLastAlreadyYielded)
                return false;
            if (this.prev.MoveNext())
            {
                this.Current = this.prev.Current;
            }
            else
            {
                this.Current = this.toAppend;
                this.theLastAlreadyYielded = true;
            }
            return true;
        }

        public T Current { get; private set; }
    }
}