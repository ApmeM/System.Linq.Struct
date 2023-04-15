// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Linq.Expressions;

namespace System.Linq.Struct
{
    internal static class SumMethodGenerator<T>
    {
        public static Func<T, T, T> sum;

        static SumMethodGenerator()
        {
            var a = Expression.Parameter(typeof(T));
            var b = Expression.Parameter(typeof(T));
            sum = (Func<T, T, T>)Expression.Lambda(Expression.Add(a, b), a, b).Compile();
        }
    }
}