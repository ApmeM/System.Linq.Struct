﻿// Copyright (c) Angouri 2021.
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
            theLastAlreadyYielded = false;
            this.toAppend = toAppend;
            Current = default(T);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (theLastAlreadyYielded)
                return false;
            if (prev.MoveNext())
            {
                Current = prev.Current;
            }
            else
            {
                Current = toAppend;
                theLastAlreadyYielded = true;
            }
            return true;
        }

        public T Current { get; private set; }
    }
}