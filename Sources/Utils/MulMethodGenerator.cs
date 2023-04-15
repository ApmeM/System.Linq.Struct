// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Linq.Expressions;

namespace System.Linq.Struct
{
    internal static class MulMethodGenerator<T>
    {
        public static Func<T, T, T> mul;

        static MulMethodGenerator()
        {
            var a = Expression.Parameter(typeof(T));
            var b = Expression.Parameter(typeof(T));
            mul = (Func<T, T, T>)Expression.Lambda(Expression.Multiply(a, b), a, b).Compile();
        }
    }


}