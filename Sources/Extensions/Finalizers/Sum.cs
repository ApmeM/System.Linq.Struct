// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace System.Linq.Struct
{
    public static partial class ActiveLinqExtensions
    {
        public static int Sum<TEnumerator>(this RefLinqEnumerable<int, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<int>
        {
            var result = 0;
            foreach (var el in seq)
                result += el;
            return result;
        }
        public static float Sum<TEnumerator>(this RefLinqEnumerable<float, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<float>
        {
            var result = 0f;
            foreach (var el in seq)
                result += el;
            return result;
        }
        public static double Sum<TEnumerator>(this RefLinqEnumerable<double, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<double>
        {
            var result = 0d;
            foreach (var el in seq)
                result += el;
            return result;
        }
    }
}