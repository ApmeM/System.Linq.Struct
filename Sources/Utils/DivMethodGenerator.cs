// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Linq.Expressions;

namespace System.Linq.Struct
{
    internal static class DivMethodGenerator<T>
    {
        public static Func<T, int, T> div;

        static DivMethodGenerator()
        {
            var a = Expression.Parameter(typeof(T));
            var b = Expression.Parameter(typeof(T));
            var c = Expression.Parameter(typeof(int));
            div = (Func<T, int, T>)Expression.Lambda(Expression.Divide(a, Expression.Convert(c, typeof(T))), a, c).Compile();
        }
    }


}