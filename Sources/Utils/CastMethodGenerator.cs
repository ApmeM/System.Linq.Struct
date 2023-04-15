// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Linq.Expressions;

namespace System.Linq.Struct
{
    internal static class CastMethodGenerator<T, U>
    {
        public static Func<T, U> cast;

        static CastMethodGenerator()
        {
            var a = Expression.Parameter(typeof(T));
            cast = (Func<T, U>)Expression.Lambda(Expression.Convert(a, typeof(U)), a).Compile();
        }
    }


}