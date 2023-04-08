// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq.Struct
{
    public static partial class Extensions
    {
        public static RefLinqEnumerable<T, SelectMany<T, TPrevious, TEnumeratorOfEnumerators>> SelectMany<T, TPrevious, TEnumeratorOfEnumerators>(this RefLinqEnumerable<RefLinqEnumerable<T, TPrevious>, TEnumeratorOfEnumerators> prev)
            where TPrevious : IRefEnumerator<T>
            where TEnumeratorOfEnumerators : IRefEnumerator<RefLinqEnumerable<T, TPrevious>>
            => new RefLinqEnumerable<T, SelectMany<T, TPrevious, TEnumeratorOfEnumerators>>(new SelectMany<T, TPrevious, TEnumeratorOfEnumerators>(prev.enumerator));

        public static RefLinqEnumerable<U, SelectMany<U, TUEnumerator, Select<T, TPrevious, RefLinqEnumerable<U, TUEnumerator>>>> SelectMany<T, TPrevious, U, TUEnumerator>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, RefLinqEnumerable<U, TUEnumerator>> func)
            where TPrevious : IRefEnumerator<T>
            where TUEnumerator : IRefEnumerator<U>
            => prev.Select(func).SelectMany();

        public static T Aggregate<T, TPrevious>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, T, T> agg)
            where TPrevious : IRefEnumerator<T>
        {
            if (!prev.enumerator.MoveNext())
                throw new InvalidOperationException("Sequence contains no elements");
            var c = prev.enumerator.Current;

            while (prev.enumerator.MoveNext())
                c = agg.Invoke(c, prev.enumerator.Current);

            return c;
        }

        public static TAccumulate Aggregate<T, TPrevious, TAccumulate>(this RefLinqEnumerable<T, TPrevious> prev, TAccumulate acc, Func<TAccumulate, T, TAccumulate> agg)
            where TPrevious : IRefEnumerator<T>
        {
            var res = acc;
            foreach (var el in prev)
                res = agg.Invoke(res, el);
            return res;
        }

        public static bool All<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
        {
            foreach (var el in seq)
                if (!pred.Invoke(el))
                    return false;
            return true;
        }

        public static bool Any<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            return seq.enumerator.MoveNext();
        }

        public static bool Contains<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, T toFind)
            where TEnumerator : IRefEnumerator<T>
        {
            foreach (var el in seq)
            {
                if (toFind != null && EqualityComparer<T>.Default.Equals(toFind, el) || toFind == null && el == null)
                    return true;
            }
            return false;
        }

        public static int Count<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var c = 0;
            foreach (var _ in seq)
                c++;
            return c;
        }
        public static T FirstOrDefault<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            if (seq.enumerator.MoveNext())
                return seq.enumerator.Current;
            return default(T);
        }

        public static T First<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            if (seq.enumerator.MoveNext())
                return seq.enumerator.Current;
            throw new InvalidOperationException("Sequence contains no elements");
        }

        public static T Last<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            if (!seq.enumerator.MoveNext())
                throw new InvalidOperationException("Sequence contains no elements");
            var curr = seq.enumerator.Current;
            while (seq.enumerator.MoveNext())
                curr = seq.enumerator.Current;
            return curr;
        }

        public static T LastOrDefault<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            if (!seq.enumerator.MoveNext())
                return default(T);
            var curr = seq.enumerator.Current;
            while (seq.enumerator.MoveNext())
                curr = seq.enumerator.Current;
            return curr;
        }
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

        public static T SingleOrDefault<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            if (!seq.enumerator.MoveNext())
                return default(T);
            var res = seq.enumerator.Current;
            if (seq.enumerator.MoveNext())
                return default(T);
            return res;
        }

        public static T Max<TEnumerator, T>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            bool haveData = false;
            T max = default(T);
            foreach (var v in seq)
            {
                if (!haveData)
                {
                    max = v;
                }
                else if (Comparer<T>.Default.Compare(max, v) < 0)
                {
                    max = v;
                }

                haveData = true;
            }

            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return max;
        }


        public static T MaxBy<TEnumerator, T, T2>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, T2> keySelector)
            where TEnumerator : IRefEnumerator<T>
        {
            bool haveData = false;
            T max = default(T);
            T2 maxValue = default(T2);
            foreach (var v in seq)
            {
                if (!haveData)
                {
                    max = v;
                    maxValue = keySelector(v);
                }
                else if (Comparer<T2>.Default.Compare(maxValue, keySelector(v)) < 0)
                {
                    max = v;
                    maxValue = keySelector(v);
                }

                haveData = true;
            }

            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return max;
        }


        public static T Min<TEnumerator, T>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            bool haveData = false;
            T max = default(T);
            foreach (var v in seq)
            {
                if (!haveData)
                {
                    max = v;
                }
                else if (Comparer<T>.Default.Compare(max, v) > 0)
                {
                    max = v;
                }

                haveData = true;
            }

            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return max;
        }

        public static T MinBy<TEnumerator, T, T2>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, T2> keySelector)
            where TEnumerator : IRefEnumerator<T>
        {
            bool haveData = false;
            T max = default(T);
            T2 maxValue = default(T2);
            foreach (var v in seq)
            {
                if (!haveData)
                {
                    max = v;
                    maxValue = keySelector(v);
                }
                else if (Comparer<T2>.Default.Compare(maxValue, keySelector(v)) > 0)
                {
                    max = v;
                    maxValue = keySelector(v);
                }

                haveData = true;
            }

            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return max;
        }

        static Func<T, T, T> BuildSum<T>()
        {
            var a = Expression.Parameter(typeof(T));
            var b = Expression.Parameter(typeof(T));
            return (Func<T, T, T>)Expression.Lambda(Expression.Add(a, b), a, b).Compile();
        }

        public static T Sum<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            // TODO: fix memory allocation.
            var func = BuildSum<T>();
            T result = default(T);
            foreach (var el in seq)
                result = func(result, el);
            return result;
        }

        static Func<T, T, T> BuildMultiply<T>()
        {
            var a = Expression.Parameter(typeof(T));
            var b = Expression.Parameter(typeof(T));
            return (Func<T, T, T>)Expression.Lambda(Expression.Multiply(a, b), a, b).Compile();
        }

        public static T Multiply<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            // TODO: fix memory allocation.
            var func = BuildMultiply<T>();
            bool resultInitialized = false;
            T result = default(T);
            foreach (var el in seq)
            {
                if (!resultInitialized)
                {
                    result = el;
                    resultInitialized = true;
                }
                else
                {
                    result = func(result, el);
                }
            }

            return result;
        }
    }
}