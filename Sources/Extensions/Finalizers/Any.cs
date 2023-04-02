// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace System.Linq.Struct
{

    public static partial class ActiveLinqExtensions
    {
        public static bool Any<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            return seq.enumerator.MoveNext();
        }

        public static bool Any<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
        {
            return seq.Where(pred).Any();
        }
    }
}