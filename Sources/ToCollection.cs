// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;

namespace System.Linq.Struct
{
    public static partial class ToCollection
    {
        public static HashSet<T> ToHashSet<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var list = new HashSet<T>();
            foreach (var el in seq)
                list.Add(el);
            return list;
        }

        public static HashSet<T> ToHashSet<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, HashSet<T> list)
            where TEnumerator : IRefEnumerator<T>
        {
            list.Clear();
            foreach (var el in seq)
                list.Add(el);
            return list;
        }

        public static List<T> ToList<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var list = new List<T>();
            foreach (var el in seq)
                list.Add(el);
            return list;
        }

        public static List<T> ToList<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, List<T> list)
            where TEnumerator : IRefEnumerator<T>
        {
            list.Clear();
            foreach (var el in seq)
                list.Add(el);
            return list;
        }

        public static T[] ToArray<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<T>
        {
            var list = new List<T>();
            foreach (var el in seq)
                list.Add(el);
            return list.ToArray();
        }

        public static T[] ToArray<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, List<T> list)
            where TEnumerator : IRefEnumerator<T>
        {
            list.Clear();
            foreach (var el in seq)
                list.Add(el);
            return list.ToArray();
        }

        public static Dictionary<TKey, T> ToDictionary<T, TEnumerator, TKey>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, TKey> keySelector)
            where TEnumerator : IRefEnumerator<T>
        {
            var dict = new Dictionary<TKey, T>();
            foreach (var el in seq)
                dict.Add(keySelector(el), el);
            return dict;
        }

        public static Dictionary<TKey, T> ToDictionary<T, TEnumerator, TKey>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, TKey> keySelector, Dictionary<TKey, T> dict)
            where TEnumerator : IRefEnumerator<T>
        {
            dict.Clear();
            foreach (var el in seq)
                dict.Add(keySelector(el), el);
            return dict;
        }

        public static Dictionary<TKey, TValue> ToDictionary<T, TEnumerator, TKey, TValue>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, TKey> keySelector, Func<T, TValue> valueSelector)
            where TEnumerator : IRefEnumerator<T>
        {
            var dict = new Dictionary<TKey, TValue>();
            foreach (var el in seq)
                dict.Add(keySelector(el), valueSelector(el));
            return dict;
        }

        public static Dictionary<TKey, TValue> ToDictionary<T, TEnumerator, TKey, TValue>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, TKey> keySelector, Func<T, TValue> valueSelector, Dictionary<TKey, TValue> dict)
            where TEnumerator : IRefEnumerator<T>
        {
            dict.Clear();
            foreach (var el in seq)
                dict.Add(keySelector(el), valueSelector(el));
            return dict;
        }
    }
}