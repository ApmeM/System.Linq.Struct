// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    
    public struct Cast<T, TEnumerator, U>
        : IRefEnumerator<U>
        where TEnumerator : IRefEnumerator<T>
    {

        private static Func<T, U> cast;

        static Cast()
        {
            var a = Expression.Parameter(typeof(T));
            cast = (Func<T, U>)Expression.Lambda(Expression.Convert(a, typeof(U)), a).Compile();
        }

        public Cast(TEnumerator prev)
        {
            this.prev = prev;
            this.Current = default(U);
        }
        private TEnumerator prev;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!prev.MoveNext())
                return false;
            this.Current = cast(prev.Current);
            return true;
        }
        
        public U Current {get; private set;}

        public Cast<T, TEnumerator, U> GetEnumerator() => this;
    }
}