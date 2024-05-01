// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;

namespace System.Linq.Struct
{
    public static partial class Extensions
    {
        internal static RefLinqEnumerable<T, SelectMany<T, TPrevious, TEnumeratorOfEnumerators>> SelectMany<T, TPrevious, TEnumeratorOfEnumerators>(this RefLinqEnumerable<RefLinqEnumerable<T, TPrevious>, TEnumeratorOfEnumerators> prev)
            where TPrevious : IRefEnumerator<T>
            where TEnumeratorOfEnumerators : IRefEnumerator<RefLinqEnumerable<T, TPrevious>>
            => new RefLinqEnumerable<T, SelectMany<T, TPrevious, TEnumeratorOfEnumerators>>(new SelectMany<T, TPrevious, TEnumeratorOfEnumerators>(prev.enumerator));

        public static T Aggregate<T, TPrevious>(this RefLinqEnumerable<T, TPrevious> seq, Func<T, T, T> agg)
            where TPrevious : IRefEnumerator<T>
        {
            var found = false;
            var result = default(T);
            foreach (var el in seq)
            {
                if (!found)
                {
                    result = el;
                    found = true;
                    continue;
                }

                result = agg.Invoke(result, el);
            }
            if (!found)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
            return result;
        }

        public static TAccumulate Aggregate<T, TPrevious, TAccumulate>(this RefLinqEnumerable<T, TPrevious> seq, TAccumulate acc, Func<TAccumulate, T, TAccumulate> agg)
            where TPrevious : IRefEnumerator<T>
        {
            var res = acc;
            foreach (var el in seq)
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
            foreach (var _ in seq)
                return true;
            return false;
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
            foreach (var el in seq)
                return el;
            return default(T);
        }

        public static T First<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            foreach (var el in seq)
                return el;
            throw new InvalidOperationException("Sequence contains no elements");
        }

        public static T Last<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var found = false;
            var result = default(T);
            foreach (var el in seq)
            {
                found = true;
                result = el;
            }
            if (!found)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
            return result;
        }

        public static T LastOrDefault<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var result = default(T);
            foreach (var el in seq)
            {
                result = el;
            }
            return result;
        }
        public static T Single<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var found = false;
            var result = default(T);
            foreach (var el in seq)
            {
                if (found)
                {
                    throw new InvalidOperationException("Sequence contains more than one element");
                }
                found = true;
                result = el;
            }
            if (!found)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
            return result;
        }

        public static T SingleOrDefault<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var found = false;
            var result = default(T);
            foreach (var el in seq)
            {
                if (found)
                {
                    throw new InvalidOperationException("Sequence contains more than one element");
                }
                found = true;
                result = el;
            }
            return result;
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
            var max = default(T);
            var maxValue = default(T2);
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
            var haveData = false;
            var max = default(T);
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
            var haveData = false;
            var max = default(T);
            var maxValue = default(T2);
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

        public static T Sum<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var result = default(T);
            foreach (var el in seq)
                result = SumMethodGenerator<T>.sum(result, el);
            return result;
        }

        public static T Average<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var result = default(T);
            var count = 0;
            foreach (var el in seq)
            {
                result = SumMethodGenerator<T>.sum(result, el);
                count++;
            }
            return DivMethodGenerator<T>.div(result, count);
        }

        public static T Multiply<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var resultInitialized = false;
            var result = default(T);
            foreach (var el in seq)
            {
                if (!resultInitialized)
                {
                    result = el;
                    resultInitialized = true;
                }
                else
                {
                    result = MulMethodGenerator<T>.mul(result, el);
                }
            }

            return result;
        }
    }
}