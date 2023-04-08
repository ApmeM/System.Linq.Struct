// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace System.Linq.Struct
{
    public static partial class LazyLinqExtensions
    {
        public static RefLinqEnumerable<T, ArrayEnumerator<T>> ToRefLinq<T>(this T[] c)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c));
        public static RefLinqEnumerable<int, RangeEnumerator> Range(int start, int count)
            => new RefLinqEnumerable<int, RangeEnumerator>(new RangeEnumerator(start, count));
    }
}