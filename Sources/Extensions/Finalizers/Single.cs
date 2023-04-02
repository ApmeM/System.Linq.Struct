﻿// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace System.Linq.Struct
{

    public static partial class ActiveLinqExtensions
    {
        public static T Single<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            if (!seq.enumerator.MoveNext())
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
            var res = seq.enumerator.Current;
            if (seq.enumerator.MoveNext())
                throw new InvalidOperationException("Sequence contains more than one element");
            return res;
        }
    }
}