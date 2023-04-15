// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace System.Linq.Struct
{
    public interface IRefEnumerator<T>
    {
        bool MoveNext();

        T Current { get; }
    }

    public partial struct RefLinqEnumerable<TSource, TPrevious>
        where TPrevious : IRefEnumerator<TSource>
    {
        public TPrevious enumerator;

        public RefLinqEnumerable(TPrevious en)
            => enumerator = en;

        public TPrevious GetEnumerator() => enumerator;
    }
}