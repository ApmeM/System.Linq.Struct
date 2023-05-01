using System.Collections.Generic;
using System;

namespace System.Linq.Struct
{
    public static partial class GeneratedExtensions
    {
        public static RefLinqEnumerable<TSource, IReadOnlyListEnumerator<TSource>> Build<TSource>(IReadOnlyList<TSource> c)
            => new RefLinqEnumerable<TSource, IReadOnlyListEnumerator<TSource>>(new IReadOnlyListEnumerator<TSource>(c));
        public static RefLinqEnumerable<TSource, ArrayEnumerator<TSource>> Build<TSource>(TSource[] c)
            => new RefLinqEnumerable<TSource, ArrayEnumerator<TSource>>(new ArrayEnumerator<TSource>(c));
        public static RefLinqEnumerable<TSource, HashSetEnumerator<TSource>> Build<TSource>(HashSet<TSource> c)
            => new RefLinqEnumerable<TSource, HashSetEnumerator<TSource>>(new HashSetEnumerator<TSource>(c));
        public static RefLinqEnumerable<TSource, MultiHashSetWrapperEnumerator<TSource>> Build<TSource>(MultiHashSetWrapper<TSource> c)
            => new RefLinqEnumerable<TSource, MultiHashSetWrapperEnumerator<TSource>>(new MultiHashSetWrapperEnumerator<TSource>(c));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>> Build<TSource1, TSource2>(Dictionary<TSource1, TSource2> c)
            => new RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>(new DictionaryEnumerator<TSource1, TSource2>(c));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>> Build<TSource1, TSource2>(MultiDictionaryWrapper<TSource1, TSource2> c)
            => new RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>(new MultiDictionaryWrapperEnumerator<TSource1, TSource2>(c));
        public static int Count<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Count(pred);
        public static int Count<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Count(pred);
        public static int Count<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Count(pred);
        public static int Count<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Count(pred);
        public static int Count<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Count(pred);
        public static int Count<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Count(pred);
        public static bool Any<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Any(pred);
        public static bool Any<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Any(pred);
        public static bool Any<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Any(pred);
        public static bool Any<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Any(pred);
        public static bool Any<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Any(pred);
        public static bool Any<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Any(pred);
        public static TSource Single<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Single(pred);
        public static TSource Single<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Single(pred);
        public static TSource Single<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Single(pred);
        public static TSource Single<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Single(pred);
        public static KeyValuePair<TSource1, TSource2> Single<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Single(pred);
        public static KeyValuePair<TSource1, TSource2> Single<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Single(pred);
        public static TSource SingleOrDefault<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).SingleOrDefault(pred);
        public static TSource SingleOrDefault<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).SingleOrDefault(pred);
        public static TSource SingleOrDefault<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).SingleOrDefault(pred);
        public static TSource SingleOrDefault<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).SingleOrDefault(pred);
        public static KeyValuePair<TSource1, TSource2> SingleOrDefault<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).SingleOrDefault(pred);
        public static KeyValuePair<TSource1, TSource2> SingleOrDefault<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).SingleOrDefault(pred);
        public static TSource First<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).First(pred);
        public static TSource First<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).First(pred);
        public static TSource First<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).First(pred);
        public static TSource First<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).First(pred);
        public static KeyValuePair<TSource1, TSource2> First<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).First(pred);
        public static KeyValuePair<TSource1, TSource2> First<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).First(pred);
        public static TSource FirstOrDefault<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).FirstOrDefault(pred);
        public static TSource FirstOrDefault<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).FirstOrDefault(pred);
        public static TSource FirstOrDefault<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).FirstOrDefault(pred);
        public static TSource FirstOrDefault<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).FirstOrDefault(pred);
        public static KeyValuePair<TSource1, TSource2> FirstOrDefault<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).FirstOrDefault(pred);
        public static KeyValuePair<TSource1, TSource2> FirstOrDefault<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).FirstOrDefault(pred);
        public static TSource Last<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Last(pred);
        public static TSource Last<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Last(pred);
        public static TSource Last<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Last(pred);
        public static TSource Last<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Last(pred);
        public static KeyValuePair<TSource1, TSource2> Last<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Last(pred);
        public static KeyValuePair<TSource1, TSource2> Last<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Last(pred);
        public static TSource LastOrDefault<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).LastOrDefault(pred);
        public static TSource LastOrDefault<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).LastOrDefault(pred);
        public static TSource LastOrDefault<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).LastOrDefault(pred);
        public static TSource LastOrDefault<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).LastOrDefault(pred);
        public static KeyValuePair<TSource1, TSource2> LastOrDefault<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).LastOrDefault(pred);
        public static KeyValuePair<TSource1, TSource2> LastOrDefault<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).LastOrDefault(pred);
        public static TSource Max<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Max(pred);
        public static TSource Max<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Max(pred);
        public static TSource Max<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Max(pred);
        public static TSource Max<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Max(pred);
        public static KeyValuePair<TSource1, TSource2> Max<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Max(pred);
        public static KeyValuePair<TSource1, TSource2> Max<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Max(pred);
        public static TSource Min<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Min(pred);
        public static TSource Min<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Min(pred);
        public static TSource Min<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Min(pred);
        public static TSource Min<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Min(pred);
        public static KeyValuePair<TSource1, TSource2> Min<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Min(pred);
        public static KeyValuePair<TSource1, TSource2> Min<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Min(pred);
        public static TSource Average<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Average(pred);
        public static TSource Average<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Average(pred);
        public static TSource Average<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Average(pred);
        public static TSource Average<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Average(pred);
        public static KeyValuePair<TSource1, TSource2> Average<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Average(pred);
        public static KeyValuePair<TSource1, TSource2> Average<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Average(pred);
        public static TSource Sum<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Sum(pred);
        public static TSource Sum<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Sum(pred);
        public static TSource Sum<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Sum(pred);
        public static TSource Sum<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Sum(pred);
        public static KeyValuePair<TSource1, TSource2> Sum<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Sum(pred);
        public static KeyValuePair<TSource1, TSource2> Sum<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Sum(pred);
        public static TSource Multiply<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).Multiply(pred);
        public static TSource Multiply<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).Multiply(pred);
        public static TSource Multiply<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).Multiply(pred);
        public static TSource Multiply<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).Multiply(pred);
        public static KeyValuePair<TSource1, TSource2> Multiply<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Multiply(pred);
        public static KeyValuePair<TSource1, TSource2> Multiply<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).Multiply(pred);
        public static List<TSource> ToList<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).ToList();
        public static List<TSource> ToList<TSource>(this TSource[] c)
            => Build(c).ToList();
        public static List<TSource> ToList<TSource>(this HashSet<TSource> c)
            => Build(c).ToList();
        public static List<TSource> ToList<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).ToList();
        public static List<KeyValuePair<TSource1, TSource2>> ToList<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).ToList();
        public static List<KeyValuePair<TSource1, TSource2>> ToList<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).ToList();
        public static List<TSource> ToList<TSource>(this IReadOnlyList<TSource> c, List<TSource> list)
            => Build(c).ToList(list);
        public static List<TSource> ToList<TSource>(this TSource[] c, List<TSource> list)
            => Build(c).ToList(list);
        public static List<TSource> ToList<TSource>(this HashSet<TSource> c, List<TSource> list)
            => Build(c).ToList(list);
        public static List<TSource> ToList<TSource>(this MultiHashSetWrapper<TSource> c, List<TSource> list)
            => Build(c).ToList(list);
        public static List<KeyValuePair<TSource1, TSource2>> ToList<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, List<KeyValuePair<TSource1, TSource2>> list)
            => Build(c).ToList(list);
        public static List<KeyValuePair<TSource1, TSource2>> ToList<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, List<KeyValuePair<TSource1, TSource2>> list)
            => Build(c).ToList(list);
        public static TSource[] ToArray<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).ToArray();
        public static TSource[] ToArray<TSource>(this TSource[] c)
            => Build(c).ToArray();
        public static TSource[] ToArray<TSource>(this HashSet<TSource> c)
            => Build(c).ToArray();
        public static TSource[] ToArray<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).ToArray();
        public static KeyValuePair<TSource1, TSource2>[] ToArray<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).ToArray();
        public static KeyValuePair<TSource1, TSource2>[] ToArray<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).ToArray();
        public static TSource[] ToArray<TSource>(this IReadOnlyList<TSource> c, List<TSource> list)
            => Build(c).ToArray(list);
        public static TSource[] ToArray<TSource>(this TSource[] c, List<TSource> list)
            => Build(c).ToArray(list);
        public static TSource[] ToArray<TSource>(this HashSet<TSource> c, List<TSource> list)
            => Build(c).ToArray(list);
        public static TSource[] ToArray<TSource>(this MultiHashSetWrapper<TSource> c, List<TSource> list)
            => Build(c).ToArray(list);
        public static KeyValuePair<TSource1, TSource2>[] ToArray<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, List<KeyValuePair<TSource1, TSource2>> list)
            => Build(c).ToArray(list);
        public static KeyValuePair<TSource1, TSource2>[] ToArray<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, List<KeyValuePair<TSource1, TSource2>> list)
            => Build(c).ToArray(list);
        public static HashSet<TSource> ToHashSet<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).ToHashSet();
        public static HashSet<TSource> ToHashSet<TSource>(this TSource[] c)
            => Build(c).ToHashSet();
        public static HashSet<TSource> ToHashSet<TSource>(this HashSet<TSource> c)
            => Build(c).ToHashSet();
        public static HashSet<TSource> ToHashSet<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).ToHashSet();
        public static HashSet<KeyValuePair<TSource1, TSource2>> ToHashSet<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).ToHashSet();
        public static HashSet<KeyValuePair<TSource1, TSource2>> ToHashSet<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).ToHashSet();
        public static HashSet<TSource> ToHashSet<TSource>(this IReadOnlyList<TSource> c, HashSet<TSource> set)
            => Build(c).ToHashSet(set);
        public static HashSet<TSource> ToHashSet<TSource>(this TSource[] c, HashSet<TSource> set)
            => Build(c).ToHashSet(set);
        public static HashSet<TSource> ToHashSet<TSource>(this HashSet<TSource> c, HashSet<TSource> set)
            => Build(c).ToHashSet(set);
        public static HashSet<TSource> ToHashSet<TSource>(this MultiHashSetWrapper<TSource> c, HashSet<TSource> set)
            => Build(c).ToHashSet(set);
        public static HashSet<KeyValuePair<TSource1, TSource2>> ToHashSet<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, HashSet<KeyValuePair<TSource1, TSource2>> set)
            => Build(c).ToHashSet(set);
        public static HashSet<KeyValuePair<TSource1, TSource2>> ToHashSet<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, HashSet<KeyValuePair<TSource1, TSource2>> set)
            => Build(c).ToHashSet(set);
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IReadOnlyList<TSource> c, Func<TSource, TKey> keySelector)
            => Build(c).ToDictionary(keySelector);
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this TSource[] c, Func<TSource, TKey> keySelector)
            => Build(c).ToDictionary(keySelector);
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this HashSet<TSource> c, Func<TSource, TKey> keySelector)
            => Build(c).ToDictionary(keySelector);
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this MultiHashSetWrapper<TSource> c, Func<TSource, TKey> keySelector)
            => Build(c).ToDictionary(keySelector);
        public static Dictionary<TKey, KeyValuePair<TSource1, TSource2>> ToDictionary<TSource1, TSource2, TKey>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TKey> keySelector)
            => Build(c).ToDictionary(keySelector);
        public static Dictionary<TKey, KeyValuePair<TSource1, TSource2>> ToDictionary<TSource1, TSource2, TKey>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TKey> keySelector)
            => Build(c).ToDictionary(keySelector);
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IReadOnlyList<TSource> c, Func<TSource, TKey> keySelector, Dictionary<TKey, TSource> dict)
            => Build(c).ToDictionary(keySelector, dict);
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this TSource[] c, Func<TSource, TKey> keySelector, Dictionary<TKey, TSource> dict)
            => Build(c).ToDictionary(keySelector, dict);
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this HashSet<TSource> c, Func<TSource, TKey> keySelector, Dictionary<TKey, TSource> dict)
            => Build(c).ToDictionary(keySelector, dict);
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this MultiHashSetWrapper<TSource> c, Func<TSource, TKey> keySelector, Dictionary<TKey, TSource> dict)
            => Build(c).ToDictionary(keySelector, dict);
        public static Dictionary<TKey, KeyValuePair<TSource1, TSource2>> ToDictionary<TSource1, TSource2, TKey>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TKey> keySelector, Dictionary<TKey, KeyValuePair<TSource1, TSource2>> dict)
            => Build(c).ToDictionary(keySelector, dict);
        public static Dictionary<TKey, KeyValuePair<TSource1, TSource2>> ToDictionary<TSource1, TSource2, TKey>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TKey> keySelector, Dictionary<TKey, KeyValuePair<TSource1, TSource2>> dict)
            => Build(c).ToDictionary(keySelector, dict);
        public static Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(this IReadOnlyList<TSource> c, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => Build(c).ToDictionary(keySelector, valueSelector);
        public static Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(this TSource[] c, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => Build(c).ToDictionary(keySelector, valueSelector);
        public static Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(this HashSet<TSource> c, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => Build(c).ToDictionary(keySelector, valueSelector);
        public static Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(this MultiHashSetWrapper<TSource> c, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => Build(c).ToDictionary(keySelector, valueSelector);
        public static Dictionary<TKey, TValue> ToDictionary<TSource1, TSource2, TKey, TValue>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TKey> keySelector, Func<KeyValuePair<TSource1, TSource2>, TValue> valueSelector)
            => Build(c).ToDictionary(keySelector, valueSelector);
        public static Dictionary<TKey, TValue> ToDictionary<TSource1, TSource2, TKey, TValue>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TKey> keySelector, Func<KeyValuePair<TSource1, TSource2>, TValue> valueSelector)
            => Build(c).ToDictionary(keySelector, valueSelector);
        public static Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(this IReadOnlyList<TSource> c, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, Dictionary<TKey, TValue> dict)
            => Build(c).ToDictionary(keySelector, valueSelector, dict);
        public static Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(this TSource[] c, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, Dictionary<TKey, TValue> dict)
            => Build(c).ToDictionary(keySelector, valueSelector, dict);
        public static Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(this HashSet<TSource> c, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, Dictionary<TKey, TValue> dict)
            => Build(c).ToDictionary(keySelector, valueSelector, dict);
        public static Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(this MultiHashSetWrapper<TSource> c, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, Dictionary<TKey, TValue> dict)
            => Build(c).ToDictionary(keySelector, valueSelector, dict);
        public static Dictionary<TKey, TValue> ToDictionary<TSource1, TSource2, TKey, TValue>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TKey> keySelector, Func<KeyValuePair<TSource1, TSource2>, TValue> valueSelector, Dictionary<TKey, TValue> dict)
            => Build(c).ToDictionary(keySelector, valueSelector, dict);
        public static Dictionary<TKey, TValue> ToDictionary<TSource1, TSource2, TKey, TValue>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TKey> keySelector, Func<KeyValuePair<TSource1, TSource2>, TValue> valueSelector, Dictionary<TKey, TValue> dict)
            => Build(c).ToDictionary(keySelector, valueSelector, dict);
        public static int Count<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Count();
        public static int Count<TSource>(this TSource[] c)
            => Build(c).Count();
        public static int Count<TSource>(this HashSet<TSource> c)
            => Build(c).Count();
        public static int Count<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Count();
        public static int Count<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Count();
        public static int Count<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Count();
        public static bool Any<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Any();
        public static bool Any<TSource>(this TSource[] c)
            => Build(c).Any();
        public static bool Any<TSource>(this HashSet<TSource> c)
            => Build(c).Any();
        public static bool Any<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Any();
        public static bool Any<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Any();
        public static bool Any<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Any();
        public static TSource Single<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Single();
        public static TSource Single<TSource>(this TSource[] c)
            => Build(c).Single();
        public static TSource Single<TSource>(this HashSet<TSource> c)
            => Build(c).Single();
        public static TSource Single<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Single();
        public static KeyValuePair<TSource1, TSource2> Single<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Single();
        public static KeyValuePair<TSource1, TSource2> Single<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Single();
        public static TSource SingleOrDefault<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).SingleOrDefault();
        public static TSource SingleOrDefault<TSource>(this TSource[] c)
            => Build(c).SingleOrDefault();
        public static TSource SingleOrDefault<TSource>(this HashSet<TSource> c)
            => Build(c).SingleOrDefault();
        public static TSource SingleOrDefault<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).SingleOrDefault();
        public static KeyValuePair<TSource1, TSource2> SingleOrDefault<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).SingleOrDefault();
        public static KeyValuePair<TSource1, TSource2> SingleOrDefault<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).SingleOrDefault();
        public static TSource First<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).First();
        public static TSource First<TSource>(this TSource[] c)
            => Build(c).First();
        public static TSource First<TSource>(this HashSet<TSource> c)
            => Build(c).First();
        public static TSource First<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).First();
        public static KeyValuePair<TSource1, TSource2> First<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).First();
        public static KeyValuePair<TSource1, TSource2> First<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).First();
        public static TSource FirstOrDefault<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).FirstOrDefault();
        public static TSource FirstOrDefault<TSource>(this TSource[] c)
            => Build(c).FirstOrDefault();
        public static TSource FirstOrDefault<TSource>(this HashSet<TSource> c)
            => Build(c).FirstOrDefault();
        public static TSource FirstOrDefault<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).FirstOrDefault();
        public static KeyValuePair<TSource1, TSource2> FirstOrDefault<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).FirstOrDefault();
        public static KeyValuePair<TSource1, TSource2> FirstOrDefault<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).FirstOrDefault();
        public static TSource Last<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Last();
        public static TSource Last<TSource>(this TSource[] c)
            => Build(c).Last();
        public static TSource Last<TSource>(this HashSet<TSource> c)
            => Build(c).Last();
        public static TSource Last<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Last();
        public static KeyValuePair<TSource1, TSource2> Last<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Last();
        public static KeyValuePair<TSource1, TSource2> Last<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Last();
        public static TSource LastOrDefault<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).LastOrDefault();
        public static TSource LastOrDefault<TSource>(this TSource[] c)
            => Build(c).LastOrDefault();
        public static TSource LastOrDefault<TSource>(this HashSet<TSource> c)
            => Build(c).LastOrDefault();
        public static TSource LastOrDefault<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).LastOrDefault();
        public static KeyValuePair<TSource1, TSource2> LastOrDefault<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).LastOrDefault();
        public static KeyValuePair<TSource1, TSource2> LastOrDefault<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).LastOrDefault();
        public static TSource Max<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Max();
        public static TSource Max<TSource>(this TSource[] c)
            => Build(c).Max();
        public static TSource Max<TSource>(this HashSet<TSource> c)
            => Build(c).Max();
        public static TSource Max<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Max();
        public static KeyValuePair<TSource1, TSource2> Max<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Max();
        public static KeyValuePair<TSource1, TSource2> Max<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Max();
        public static TSource Min<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Min();
        public static TSource Min<TSource>(this TSource[] c)
            => Build(c).Min();
        public static TSource Min<TSource>(this HashSet<TSource> c)
            => Build(c).Min();
        public static TSource Min<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Min();
        public static KeyValuePair<TSource1, TSource2> Min<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Min();
        public static KeyValuePair<TSource1, TSource2> Min<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Min();
        public static TSource Average<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Average();
        public static TSource Average<TSource>(this TSource[] c)
            => Build(c).Average();
        public static TSource Average<TSource>(this HashSet<TSource> c)
            => Build(c).Average();
        public static TSource Average<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Average();
        public static KeyValuePair<TSource1, TSource2> Average<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Average();
        public static KeyValuePair<TSource1, TSource2> Average<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Average();
        public static TSource Sum<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Sum();
        public static TSource Sum<TSource>(this TSource[] c)
            => Build(c).Sum();
        public static TSource Sum<TSource>(this HashSet<TSource> c)
            => Build(c).Sum();
        public static TSource Sum<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Sum();
        public static KeyValuePair<TSource1, TSource2> Sum<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Sum();
        public static KeyValuePair<TSource1, TSource2> Sum<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Sum();
        public static TSource Multiply<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Multiply();
        public static TSource Multiply<TSource>(this TSource[] c)
            => Build(c).Multiply();
        public static TSource Multiply<TSource>(this HashSet<TSource> c)
            => Build(c).Multiply();
        public static TSource Multiply<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Multiply();
        public static KeyValuePair<TSource1, TSource2> Multiply<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Multiply();
        public static KeyValuePair<TSource1, TSource2> Multiply<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Multiply();
        public static TSource MaxBy<TSource, TMaxByKey>(this IReadOnlyList<TSource> c, Func<TSource, TMaxByKey> keySelector)
            => Build(c).MaxBy(keySelector);
        public static TSource MaxBy<TSource, TMaxByKey>(this TSource[] c, Func<TSource, TMaxByKey> keySelector)
            => Build(c).MaxBy(keySelector);
        public static TSource MaxBy<TSource, TMaxByKey>(this HashSet<TSource> c, Func<TSource, TMaxByKey> keySelector)
            => Build(c).MaxBy(keySelector);
        public static TSource MaxBy<TSource, TMaxByKey>(this MultiHashSetWrapper<TSource> c, Func<TSource, TMaxByKey> keySelector)
            => Build(c).MaxBy(keySelector);
        public static KeyValuePair<TSource1, TSource2> MaxBy<TSource1, TSource2, TMaxByKey>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TMaxByKey> keySelector)
            => Build(c).MaxBy(keySelector);
        public static KeyValuePair<TSource1, TSource2> MaxBy<TSource1, TSource2, TMaxByKey>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TMaxByKey> keySelector)
            => Build(c).MaxBy(keySelector);
        public static TSource MinBy<TSource, TMinByKey>(this IReadOnlyList<TSource> c, Func<TSource, TMinByKey> keySelector)
            => Build(c).MinBy(keySelector);
        public static TSource MinBy<TSource, TMinByKey>(this TSource[] c, Func<TSource, TMinByKey> keySelector)
            => Build(c).MinBy(keySelector);
        public static TSource MinBy<TSource, TMinByKey>(this HashSet<TSource> c, Func<TSource, TMinByKey> keySelector)
            => Build(c).MinBy(keySelector);
        public static TSource MinBy<TSource, TMinByKey>(this MultiHashSetWrapper<TSource> c, Func<TSource, TMinByKey> keySelector)
            => Build(c).MinBy(keySelector);
        public static KeyValuePair<TSource1, TSource2> MinBy<TSource1, TSource2, TMinByKey>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TMinByKey> keySelector)
            => Build(c).MinBy(keySelector);
        public static KeyValuePair<TSource1, TSource2> MinBy<TSource1, TSource2, TMinByKey>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TMinByKey> keySelector)
            => Build(c).MinBy(keySelector);
        public static bool All<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> pred)
            => Build(c).All(pred);
        public static bool All<TSource>(this TSource[] c, Func<TSource, bool> pred)
            => Build(c).All(pred);
        public static bool All<TSource>(this HashSet<TSource> c, Func<TSource, bool> pred)
            => Build(c).All(pred);
        public static bool All<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> pred)
            => Build(c).All(pred);
        public static bool All<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).All(pred);
        public static bool All<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> pred)
            => Build(c).All(pred);
        public static bool Contains<TSource>(this IReadOnlyList<TSource> c, TSource toFind)
            => Build(c).Contains(toFind);
        public static bool Contains<TSource>(this TSource[] c, TSource toFind)
            => Build(c).Contains(toFind);
        public static bool Contains<TSource>(this HashSet<TSource> c, TSource toFind)
            => Build(c).Contains(toFind);
        public static bool Contains<TSource>(this MultiHashSetWrapper<TSource> c, TSource toFind)
            => Build(c).Contains(toFind);
        public static bool Contains<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, KeyValuePair<TSource1, TSource2> toFind)
            => Build(c).Contains(toFind);
        public static bool Contains<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, KeyValuePair<TSource1, TSource2> toFind)
            => Build(c).Contains(toFind);
        public static TSource Aggregate<TSource>(this IReadOnlyList<TSource> c, Func<TSource, TSource, TSource> agg)
            => Build(c).Aggregate(agg);
        public static TSource Aggregate<TSource>(this TSource[] c, Func<TSource, TSource, TSource> agg)
            => Build(c).Aggregate(agg);
        public static TSource Aggregate<TSource>(this HashSet<TSource> c, Func<TSource, TSource, TSource> agg)
            => Build(c).Aggregate(agg);
        public static TSource Aggregate<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, TSource, TSource> agg)
            => Build(c).Aggregate(agg);
        public static KeyValuePair<TSource1, TSource2> Aggregate<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, KeyValuePair<TSource1, TSource2>, KeyValuePair<TSource1, TSource2>> agg)
            => Build(c).Aggregate(agg);
        public static KeyValuePair<TSource1, TSource2> Aggregate<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, KeyValuePair<TSource1, TSource2>, KeyValuePair<TSource1, TSource2>> agg)
            => Build(c).Aggregate(agg);
        public static TAccumulate Aggregate<TSource, TAccumulate>(this IReadOnlyList<TSource> c, TAccumulate acc, Func<TAccumulate, TSource, TAccumulate> agg)
            => Build(c).Aggregate(acc, agg);
        public static TAccumulate Aggregate<TSource, TAccumulate>(this TSource[] c, TAccumulate acc, Func<TAccumulate, TSource, TAccumulate> agg)
            => Build(c).Aggregate(acc, agg);
        public static TAccumulate Aggregate<TSource, TAccumulate>(this HashSet<TSource> c, TAccumulate acc, Func<TAccumulate, TSource, TAccumulate> agg)
            => Build(c).Aggregate(acc, agg);
        public static TAccumulate Aggregate<TSource, TAccumulate>(this MultiHashSetWrapper<TSource> c, TAccumulate acc, Func<TAccumulate, TSource, TAccumulate> agg)
            => Build(c).Aggregate(acc, agg);
        public static TAccumulate Aggregate<TSource1, TSource2, TAccumulate>(this Dictionary<TSource1, TSource2> c, TAccumulate acc, Func<TAccumulate, KeyValuePair<TSource1, TSource2>, TAccumulate> agg)
            => Build(c).Aggregate(acc, agg);
        public static TAccumulate Aggregate<TSource1, TSource2, TAccumulate>(this MultiDictionaryWrapper<TSource1, TSource2> c, TAccumulate acc, Func<TAccumulate, KeyValuePair<TSource1, TSource2>, TAccumulate> agg)
            => Build(c).Aggregate(acc, agg);
        public static RefLinqEnumerable<TSource, Where<TSource, IReadOnlyListEnumerator<TSource>>> Where<TSource>(this IReadOnlyList<TSource> c, Func<TSource, bool> predicate)
            => Build(c).Where(predicate);
        public static RefLinqEnumerable<TSource, Where<TSource, ArrayEnumerator<TSource>>> Where<TSource>(this TSource[] c, Func<TSource, bool> predicate)
            => Build(c).Where(predicate);
        public static RefLinqEnumerable<TSource, Where<TSource, HashSetEnumerator<TSource>>> Where<TSource>(this HashSet<TSource> c, Func<TSource, bool> predicate)
            => Build(c).Where(predicate);
        public static RefLinqEnumerable<TSource, Where<TSource, MultiHashSetWrapperEnumerator<TSource>>> Where<TSource>(this MultiHashSetWrapper<TSource> c, Func<TSource, bool> predicate)
            => Build(c).Where(predicate);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Where<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Where<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> predicate)
            => Build(c).Where(predicate);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Where<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Where<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, bool> predicate)
            => Build(c).Where(predicate);
        public static RefLinqEnumerable<TSource, Skip<TSource, IReadOnlyListEnumerator<TSource>>> Skip<TSource>(this IReadOnlyList<TSource> c, int skip)
            => Build(c).Skip(skip);
        public static RefLinqEnumerable<TSource, Skip<TSource, ArrayEnumerator<TSource>>> Skip<TSource>(this TSource[] c, int skip)
            => Build(c).Skip(skip);
        public static RefLinqEnumerable<TSource, Skip<TSource, HashSetEnumerator<TSource>>> Skip<TSource>(this HashSet<TSource> c, int skip)
            => Build(c).Skip(skip);
        public static RefLinqEnumerable<TSource, Skip<TSource, MultiHashSetWrapperEnumerator<TSource>>> Skip<TSource>(this MultiHashSetWrapper<TSource> c, int skip)
            => Build(c).Skip(skip);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Skip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Skip<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, int skip)
            => Build(c).Skip(skip);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Skip<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Skip<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, int skip)
            => Build(c).Skip(skip);
        public static RefLinqEnumerable<TSource, Take<TSource, IReadOnlyListEnumerator<TSource>>> Take<TSource>(this IReadOnlyList<TSource> c, int take)
            => Build(c).Take(take);
        public static RefLinqEnumerable<TSource, Take<TSource, ArrayEnumerator<TSource>>> Take<TSource>(this TSource[] c, int take)
            => Build(c).Take(take);
        public static RefLinqEnumerable<TSource, Take<TSource, HashSetEnumerator<TSource>>> Take<TSource>(this HashSet<TSource> c, int take)
            => Build(c).Take(take);
        public static RefLinqEnumerable<TSource, Take<TSource, MultiHashSetWrapperEnumerator<TSource>>> Take<TSource>(this MultiHashSetWrapper<TSource> c, int take)
            => Build(c).Take(take);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Take<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Take<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, int take)
            => Build(c).Take(take);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Take<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Take<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, int take)
            => Build(c).Take(take);
        public static RefLinqEnumerable<TSource, Reverse<TSource, IReadOnlyListEnumerator<TSource>>> Reverse<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Reverse();
        public static RefLinqEnumerable<TSource, Reverse<TSource, ArrayEnumerator<TSource>>> Reverse<TSource>(this TSource[] c)
            => Build(c).Reverse();
        public static RefLinqEnumerable<TSource, Reverse<TSource, HashSetEnumerator<TSource>>> Reverse<TSource>(this HashSet<TSource> c)
            => Build(c).Reverse();
        public static RefLinqEnumerable<TSource, Reverse<TSource, MultiHashSetWrapperEnumerator<TSource>>> Reverse<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Reverse();
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Reverse<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Reverse<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Reverse();
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Reverse<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Reverse<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Reverse();
        public static RefLinqEnumerable<TSource, Append<TSource, IReadOnlyListEnumerator<TSource>>> Append<TSource>(this IReadOnlyList<TSource> c, TSource toAppend)
            => Build(c).Append(toAppend);
        public static RefLinqEnumerable<TSource, Append<TSource, ArrayEnumerator<TSource>>> Append<TSource>(this TSource[] c, TSource toAppend)
            => Build(c).Append(toAppend);
        public static RefLinqEnumerable<TSource, Append<TSource, HashSetEnumerator<TSource>>> Append<TSource>(this HashSet<TSource> c, TSource toAppend)
            => Build(c).Append(toAppend);
        public static RefLinqEnumerable<TSource, Append<TSource, MultiHashSetWrapperEnumerator<TSource>>> Append<TSource>(this MultiHashSetWrapper<TSource> c, TSource toAppend)
            => Build(c).Append(toAppend);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Append<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Append<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, KeyValuePair<TSource1, TSource2> toAppend)
            => Build(c).Append(toAppend);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Append<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Append<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, KeyValuePair<TSource1, TSource2> toAppend)
            => Build(c).Append(toAppend);
        public static RefLinqEnumerable<TSource, Repeat<TSource, IReadOnlyListEnumerator<TSource>>> Repeat<TSource>(this IReadOnlyList<TSource> c, int times)
            => Build(c).Repeat(times);
        public static RefLinqEnumerable<TSource, Repeat<TSource, ArrayEnumerator<TSource>>> Repeat<TSource>(this TSource[] c, int times)
            => Build(c).Repeat(times);
        public static RefLinqEnumerable<TSource, Repeat<TSource, HashSetEnumerator<TSource>>> Repeat<TSource>(this HashSet<TSource> c, int times)
            => Build(c).Repeat(times);
        public static RefLinqEnumerable<TSource, Repeat<TSource, MultiHashSetWrapperEnumerator<TSource>>> Repeat<TSource>(this MultiHashSetWrapper<TSource> c, int times)
            => Build(c).Repeat(times);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Repeat<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Repeat<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, int times)
            => Build(c).Repeat(times);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Repeat<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Repeat<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, int times)
            => Build(c).Repeat(times);
        public static RefLinqEnumerable<TSource, Prepend<TSource, IReadOnlyListEnumerator<TSource>>> Prepend<TSource>(this IReadOnlyList<TSource> c, TSource toPrepend)
            => Build(c).Prepend(toPrepend);
        public static RefLinqEnumerable<TSource, Prepend<TSource, ArrayEnumerator<TSource>>> Prepend<TSource>(this TSource[] c, TSource toPrepend)
            => Build(c).Prepend(toPrepend);
        public static RefLinqEnumerable<TSource, Prepend<TSource, HashSetEnumerator<TSource>>> Prepend<TSource>(this HashSet<TSource> c, TSource toPrepend)
            => Build(c).Prepend(toPrepend);
        public static RefLinqEnumerable<TSource, Prepend<TSource, MultiHashSetWrapperEnumerator<TSource>>> Prepend<TSource>(this MultiHashSetWrapper<TSource> c, TSource toPrepend)
            => Build(c).Prepend(toPrepend);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Prepend<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Prepend<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, KeyValuePair<TSource1, TSource2> toPrepend)
            => Build(c).Prepend(toPrepend);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Prepend<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Prepend<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, KeyValuePair<TSource1, TSource2> toPrepend)
            => Build(c).Prepend(toPrepend);
        public static RefLinqEnumerable<TSource, OrderBy<TSource, IReadOnlyListEnumerator<TSource>, TOrderByKey>> OrderBy<TSource, TOrderByKey>(this IReadOnlyList<TSource> c, Func<TSource, TOrderByKey> keySelector)
            => Build(c).OrderBy<TOrderByKey>(keySelector);
        public static RefLinqEnumerable<TSource, OrderBy<TSource, ArrayEnumerator<TSource>, TOrderByKey>> OrderBy<TSource, TOrderByKey>(this TSource[] c, Func<TSource, TOrderByKey> keySelector)
            => Build(c).OrderBy<TOrderByKey>(keySelector);
        public static RefLinqEnumerable<TSource, OrderBy<TSource, HashSetEnumerator<TSource>, TOrderByKey>> OrderBy<TSource, TOrderByKey>(this HashSet<TSource> c, Func<TSource, TOrderByKey> keySelector)
            => Build(c).OrderBy<TOrderByKey>(keySelector);
        public static RefLinqEnumerable<TSource, OrderBy<TSource, MultiHashSetWrapperEnumerator<TSource>, TOrderByKey>> OrderBy<TSource, TOrderByKey>(this MultiHashSetWrapper<TSource> c, Func<TSource, TOrderByKey> keySelector)
            => Build(c).OrderBy<TOrderByKey>(keySelector);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, OrderBy<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TOrderByKey>> OrderBy<TSource1, TSource2, TOrderByKey>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TOrderByKey> keySelector)
            => Build(c).OrderBy<TOrderByKey>(keySelector);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, OrderBy<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TOrderByKey>> OrderBy<TSource1, TSource2, TOrderByKey>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TOrderByKey> keySelector)
            => Build(c).OrderBy<TOrderByKey>(keySelector);
        public static RefLinqEnumerable<TSource, DistinctBy<TSource, IReadOnlyListEnumerator<TSource>, TDistinctByKey>> DistinctBy<TSource, TDistinctByKey>(this IReadOnlyList<TSource> c, Func<TSource, TDistinctByKey> keySelector)
            => Build(c).DistinctBy<TDistinctByKey>(keySelector);
        public static RefLinqEnumerable<TSource, DistinctBy<TSource, ArrayEnumerator<TSource>, TDistinctByKey>> DistinctBy<TSource, TDistinctByKey>(this TSource[] c, Func<TSource, TDistinctByKey> keySelector)
            => Build(c).DistinctBy<TDistinctByKey>(keySelector);
        public static RefLinqEnumerable<TSource, DistinctBy<TSource, HashSetEnumerator<TSource>, TDistinctByKey>> DistinctBy<TSource, TDistinctByKey>(this HashSet<TSource> c, Func<TSource, TDistinctByKey> keySelector)
            => Build(c).DistinctBy<TDistinctByKey>(keySelector);
        public static RefLinqEnumerable<TSource, DistinctBy<TSource, MultiHashSetWrapperEnumerator<TSource>, TDistinctByKey>> DistinctBy<TSource, TDistinctByKey>(this MultiHashSetWrapper<TSource> c, Func<TSource, TDistinctByKey> keySelector)
            => Build(c).DistinctBy<TDistinctByKey>(keySelector);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, DistinctBy<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TDistinctByKey>> DistinctBy<TSource1, TSource2, TDistinctByKey>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TDistinctByKey> keySelector)
            => Build(c).DistinctBy<TDistinctByKey>(keySelector);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, DistinctBy<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TDistinctByKey>> DistinctBy<TSource1, TSource2, TDistinctByKey>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TDistinctByKey> keySelector)
            => Build(c).DistinctBy<TDistinctByKey>(keySelector);
        public static RefLinqEnumerable<TSource, Distinct<TSource, IReadOnlyListEnumerator<TSource>>> Distinct<TSource>(this IReadOnlyList<TSource> c)
            => Build(c).Distinct();
        public static RefLinqEnumerable<TSource, Distinct<TSource, ArrayEnumerator<TSource>>> Distinct<TSource>(this TSource[] c)
            => Build(c).Distinct();
        public static RefLinqEnumerable<TSource, Distinct<TSource, HashSetEnumerator<TSource>>> Distinct<TSource>(this HashSet<TSource> c)
            => Build(c).Distinct();
        public static RefLinqEnumerable<TSource, Distinct<TSource, MultiHashSetWrapperEnumerator<TSource>>> Distinct<TSource>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Distinct();
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Distinct<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Distinct<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Distinct();
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Distinct<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Distinct<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Distinct();
        public static RefLinqEnumerable<TOutput, Select<TSource, IReadOnlyListEnumerator<TSource>, TOutput>> Select<TSource, TOutput>(this IReadOnlyList<TSource> c, Func<TSource, TOutput> map)
            => Build(c).Select<TOutput>(map);
        public static RefLinqEnumerable<TOutput, Select<TSource, ArrayEnumerator<TSource>, TOutput>> Select<TSource, TOutput>(this TSource[] c, Func<TSource, TOutput> map)
            => Build(c).Select<TOutput>(map);
        public static RefLinqEnumerable<TOutput, Select<TSource, HashSetEnumerator<TSource>, TOutput>> Select<TSource, TOutput>(this HashSet<TSource> c, Func<TSource, TOutput> map)
            => Build(c).Select<TOutput>(map);
        public static RefLinqEnumerable<TOutput, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, TOutput>> Select<TSource, TOutput>(this MultiHashSetWrapper<TSource> c, Func<TSource, TOutput> map)
            => Build(c).Select<TOutput>(map);
        public static RefLinqEnumerable<TOutput, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TOutput>> Select<TSource1, TSource2, TOutput>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TOutput> map)
            => Build(c).Select<TOutput>(map);
        public static RefLinqEnumerable<TOutput, Select<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TOutput>> Select<TSource1, TSource2, TOutput>(this MultiDictionaryWrapper<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TOutput> map)
            => Build(c).Select<TOutput>(map);
        public static RefLinqEnumerable<TOutput, Cast<TSource, IReadOnlyListEnumerator<TSource>, TOutput>> Cast<TSource, TOutput>(this IReadOnlyList<TSource> c)
            => Build(c).Cast<TOutput>();
        public static RefLinqEnumerable<TOutput, Cast<TSource, ArrayEnumerator<TSource>, TOutput>> Cast<TSource, TOutput>(this TSource[] c)
            => Build(c).Cast<TOutput>();
        public static RefLinqEnumerable<TOutput, Cast<TSource, HashSetEnumerator<TSource>, TOutput>> Cast<TSource, TOutput>(this HashSet<TSource> c)
            => Build(c).Cast<TOutput>();
        public static RefLinqEnumerable<TOutput, Cast<TSource, MultiHashSetWrapperEnumerator<TSource>, TOutput>> Cast<TSource, TOutput>(this MultiHashSetWrapper<TSource> c)
            => Build(c).Cast<TOutput>();
        public static RefLinqEnumerable<TOutput, Cast<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TOutput>> Cast<TSource1, TSource2, TOutput>(this Dictionary<TSource1, TSource2> c)
            => Build(c).Cast<TOutput>();
        public static RefLinqEnumerable<TOutput, Cast<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TOutput>> Cast<TSource1, TSource2, TOutput>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).Cast<TOutput>();
        public static RefLinqEnumerable<TOutput, OfType<TSource, IReadOnlyListEnumerator<TSource>, TOutput>> OfType<TSource, TOutput>(this IReadOnlyList<TSource> c)
            => Build(c).OfType<TOutput>();
        public static RefLinqEnumerable<TOutput, OfType<TSource, ArrayEnumerator<TSource>, TOutput>> OfType<TSource, TOutput>(this TSource[] c)
            => Build(c).OfType<TOutput>();
        public static RefLinqEnumerable<TOutput, OfType<TSource, HashSetEnumerator<TSource>, TOutput>> OfType<TSource, TOutput>(this HashSet<TSource> c)
            => Build(c).OfType<TOutput>();
        public static RefLinqEnumerable<TOutput, OfType<TSource, MultiHashSetWrapperEnumerator<TSource>, TOutput>> OfType<TSource, TOutput>(this MultiHashSetWrapper<TSource> c)
            => Build(c).OfType<TOutput>();
        public static RefLinqEnumerable<TOutput, OfType<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TOutput>> OfType<TSource1, TSource2, TOutput>(this Dictionary<TSource1, TSource2> c)
            => Build(c).OfType<TOutput>();
        public static RefLinqEnumerable<TOutput, OfType<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TOutput>> OfType<TSource1, TSource2, TOutput>(this MultiDictionaryWrapper<TSource1, TSource2> c)
            => Build(c).OfType<TOutput>();
        public static RefLinqEnumerable<TSource, Union<TSource, IReadOnlyListEnumerator<TSource>, TSecondEnumerator>> Union<TSource, TSecondEnumerator>(this IReadOnlyList<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Union(seq2);
        public static RefLinqEnumerable<TSource, Union<TSource, IReadOnlyListEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Union<TSource>(this IReadOnlyList<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, IReadOnlyListEnumerator<TSource>, ArrayEnumerator<TSource>>> Union<TSource>(this IReadOnlyList<TSource> c, TSource[] seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, IReadOnlyListEnumerator<TSource>, HashSetEnumerator<TSource>>> Union<TSource>(this IReadOnlyList<TSource> c, HashSet<TSource> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, IReadOnlyListEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Union<TSource>(this IReadOnlyList<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Union(Build(seq2));
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
        public static RefLinqEnumerable<TSource, Union<TSource, ArrayEnumerator<TSource>, TSecondEnumerator>> Union<TSource, TSecondEnumerator>(this TSource[] c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Union(seq2);
        public static RefLinqEnumerable<TSource, Union<TSource, ArrayEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Union<TSource>(this TSource[] c, IReadOnlyList<TSource> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, ArrayEnumerator<TSource>, ArrayEnumerator<TSource>>> Union<TSource>(this TSource[] c, TSource[] seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, ArrayEnumerator<TSource>, HashSetEnumerator<TSource>>> Union<TSource>(this TSource[] c, HashSet<TSource> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, ArrayEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Union<TSource>(this TSource[] c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Union(Build(seq2));
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
        public static RefLinqEnumerable<TSource, Union<TSource, HashSetEnumerator<TSource>, TSecondEnumerator>> Union<TSource, TSecondEnumerator>(this HashSet<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Union(seq2);
        public static RefLinqEnumerable<TSource, Union<TSource, HashSetEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Union<TSource>(this HashSet<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, HashSetEnumerator<TSource>, ArrayEnumerator<TSource>>> Union<TSource>(this HashSet<TSource> c, TSource[] seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, HashSetEnumerator<TSource>, HashSetEnumerator<TSource>>> Union<TSource>(this HashSet<TSource> c, HashSet<TSource> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, HashSetEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Union<TSource>(this HashSet<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Union(Build(seq2));
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
        public static RefLinqEnumerable<TSource, Union<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondEnumerator>> Union<TSource, TSecondEnumerator>(this MultiHashSetWrapper<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Union(seq2);
        public static RefLinqEnumerable<TSource, Union<TSource, MultiHashSetWrapperEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Union<TSource>(this MultiHashSetWrapper<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, MultiHashSetWrapperEnumerator<TSource>, ArrayEnumerator<TSource>>> Union<TSource>(this MultiHashSetWrapper<TSource> c, TSource[] seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, MultiHashSetWrapperEnumerator<TSource>, HashSetEnumerator<TSource>>> Union<TSource>(this MultiHashSetWrapper<TSource> c, HashSet<TSource> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Union<TSource, MultiHashSetWrapperEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Union<TSource>(this MultiHashSetWrapper<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Union(Build(seq2));
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Union<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondEnumerator>> Union<TSource1, TSource2, TSecondEnumerator>(this Dictionary<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Union(seq2);
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Union<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Union<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Union<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Union<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, MultiDictionaryWrapper<TSource1, TSource2> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Union<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TSecondEnumerator>> Union<TSource1, TSource2, TSecondEnumerator>(this MultiDictionaryWrapper<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Union(seq2);
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
// TODO: Dictionary not supported for Union.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Union<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Union<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Union<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Union<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, MultiDictionaryWrapper<TSource1, TSource2> seq2)
            => Build(c).Union(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, IReadOnlyListEnumerator<TSource>, TSecondEnumerator>> Concat<TSource, TSecondEnumerator>(this IReadOnlyList<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Concat(seq2);
        public static RefLinqEnumerable<TSource, Concat<TSource, IReadOnlyListEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Concat<TSource>(this IReadOnlyList<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, IReadOnlyListEnumerator<TSource>, ArrayEnumerator<TSource>>> Concat<TSource>(this IReadOnlyList<TSource> c, TSource[] seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, IReadOnlyListEnumerator<TSource>, HashSetEnumerator<TSource>>> Concat<TSource>(this IReadOnlyList<TSource> c, HashSet<TSource> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, IReadOnlyListEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Concat<TSource>(this IReadOnlyList<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Concat(Build(seq2));
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
        public static RefLinqEnumerable<TSource, Concat<TSource, ArrayEnumerator<TSource>, TSecondEnumerator>> Concat<TSource, TSecondEnumerator>(this TSource[] c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Concat(seq2);
        public static RefLinqEnumerable<TSource, Concat<TSource, ArrayEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Concat<TSource>(this TSource[] c, IReadOnlyList<TSource> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, ArrayEnumerator<TSource>, ArrayEnumerator<TSource>>> Concat<TSource>(this TSource[] c, TSource[] seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, ArrayEnumerator<TSource>, HashSetEnumerator<TSource>>> Concat<TSource>(this TSource[] c, HashSet<TSource> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, ArrayEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Concat<TSource>(this TSource[] c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Concat(Build(seq2));
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
        public static RefLinqEnumerable<TSource, Concat<TSource, HashSetEnumerator<TSource>, TSecondEnumerator>> Concat<TSource, TSecondEnumerator>(this HashSet<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Concat(seq2);
        public static RefLinqEnumerable<TSource, Concat<TSource, HashSetEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Concat<TSource>(this HashSet<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, HashSetEnumerator<TSource>, ArrayEnumerator<TSource>>> Concat<TSource>(this HashSet<TSource> c, TSource[] seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, HashSetEnumerator<TSource>, HashSetEnumerator<TSource>>> Concat<TSource>(this HashSet<TSource> c, HashSet<TSource> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, HashSetEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Concat<TSource>(this HashSet<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Concat(Build(seq2));
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
        public static RefLinqEnumerable<TSource, Concat<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondEnumerator>> Concat<TSource, TSecondEnumerator>(this MultiHashSetWrapper<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Concat(seq2);
        public static RefLinqEnumerable<TSource, Concat<TSource, MultiHashSetWrapperEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Concat<TSource>(this MultiHashSetWrapper<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, MultiHashSetWrapperEnumerator<TSource>, ArrayEnumerator<TSource>>> Concat<TSource>(this MultiHashSetWrapper<TSource> c, TSource[] seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, MultiHashSetWrapperEnumerator<TSource>, HashSetEnumerator<TSource>>> Concat<TSource>(this MultiHashSetWrapper<TSource> c, HashSet<TSource> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Concat<TSource, MultiHashSetWrapperEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Concat<TSource>(this MultiHashSetWrapper<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Concat(Build(seq2));
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Concat<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondEnumerator>> Concat<TSource1, TSource2, TSecondEnumerator>(this Dictionary<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Concat(seq2);
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Concat<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Concat<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Concat<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Concat<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, MultiDictionaryWrapper<TSource1, TSource2> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Concat<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TSecondEnumerator>> Concat<TSource1, TSource2, TSecondEnumerator>(this MultiDictionaryWrapper<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Concat(seq2);
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
// TODO: Dictionary not supported for Concat.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Concat<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Concat<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Concat<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Concat<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, MultiDictionaryWrapper<TSource1, TSource2> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, IReadOnlyListEnumerator<TSource>, TSecondEnumerator>> Except<TSource, TSecondEnumerator>(this IReadOnlyList<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Except(seq2);
        public static RefLinqEnumerable<TSource, Except<TSource, IReadOnlyListEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Except<TSource>(this IReadOnlyList<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, IReadOnlyListEnumerator<TSource>, ArrayEnumerator<TSource>>> Except<TSource>(this IReadOnlyList<TSource> c, TSource[] seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, IReadOnlyListEnumerator<TSource>, HashSetEnumerator<TSource>>> Except<TSource>(this IReadOnlyList<TSource> c, HashSet<TSource> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, IReadOnlyListEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Except<TSource>(this IReadOnlyList<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Except(Build(seq2));
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
        public static RefLinqEnumerable<TSource, Except<TSource, ArrayEnumerator<TSource>, TSecondEnumerator>> Except<TSource, TSecondEnumerator>(this TSource[] c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Except(seq2);
        public static RefLinqEnumerable<TSource, Except<TSource, ArrayEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Except<TSource>(this TSource[] c, IReadOnlyList<TSource> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, ArrayEnumerator<TSource>, ArrayEnumerator<TSource>>> Except<TSource>(this TSource[] c, TSource[] seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, ArrayEnumerator<TSource>, HashSetEnumerator<TSource>>> Except<TSource>(this TSource[] c, HashSet<TSource> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, ArrayEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Except<TSource>(this TSource[] c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Except(Build(seq2));
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
        public static RefLinqEnumerable<TSource, Except<TSource, HashSetEnumerator<TSource>, TSecondEnumerator>> Except<TSource, TSecondEnumerator>(this HashSet<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Except(seq2);
        public static RefLinqEnumerable<TSource, Except<TSource, HashSetEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Except<TSource>(this HashSet<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, HashSetEnumerator<TSource>, ArrayEnumerator<TSource>>> Except<TSource>(this HashSet<TSource> c, TSource[] seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, HashSetEnumerator<TSource>, HashSetEnumerator<TSource>>> Except<TSource>(this HashSet<TSource> c, HashSet<TSource> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, HashSetEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Except<TSource>(this HashSet<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Except(Build(seq2));
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
        public static RefLinqEnumerable<TSource, Except<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondEnumerator>> Except<TSource, TSecondEnumerator>(this MultiHashSetWrapper<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Except(seq2);
        public static RefLinqEnumerable<TSource, Except<TSource, MultiHashSetWrapperEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Except<TSource>(this MultiHashSetWrapper<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, MultiHashSetWrapperEnumerator<TSource>, ArrayEnumerator<TSource>>> Except<TSource>(this MultiHashSetWrapper<TSource> c, TSource[] seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, MultiHashSetWrapperEnumerator<TSource>, HashSetEnumerator<TSource>>> Except<TSource>(this MultiHashSetWrapper<TSource> c, HashSet<TSource> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Except<TSource, MultiHashSetWrapperEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Except<TSource>(this MultiHashSetWrapper<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Except(Build(seq2));
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Except<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondEnumerator>> Except<TSource1, TSource2, TSecondEnumerator>(this Dictionary<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Except(seq2);
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Except<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Except<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Except<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Except<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, MultiDictionaryWrapper<TSource1, TSource2> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Except<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TSecondEnumerator>> Except<TSource1, TSource2, TSecondEnumerator>(this MultiDictionaryWrapper<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Except(seq2);
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
// TODO: Dictionary not supported for Except.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Except<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Except<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Except<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Except<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, MultiDictionaryWrapper<TSource1, TSource2> seq2)
            => Build(c).Except(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, IReadOnlyListEnumerator<TSource>, TSecondEnumerator>> Intersect<TSource, TSecondEnumerator>(this IReadOnlyList<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Intersect(seq2);
        public static RefLinqEnumerable<TSource, Intersect<TSource, IReadOnlyListEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Intersect<TSource>(this IReadOnlyList<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, IReadOnlyListEnumerator<TSource>, ArrayEnumerator<TSource>>> Intersect<TSource>(this IReadOnlyList<TSource> c, TSource[] seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, IReadOnlyListEnumerator<TSource>, HashSetEnumerator<TSource>>> Intersect<TSource>(this IReadOnlyList<TSource> c, HashSet<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, IReadOnlyListEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Intersect<TSource>(this IReadOnlyList<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
        public static RefLinqEnumerable<TSource, Intersect<TSource, ArrayEnumerator<TSource>, TSecondEnumerator>> Intersect<TSource, TSecondEnumerator>(this TSource[] c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Intersect(seq2);
        public static RefLinqEnumerable<TSource, Intersect<TSource, ArrayEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Intersect<TSource>(this TSource[] c, IReadOnlyList<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, ArrayEnumerator<TSource>, ArrayEnumerator<TSource>>> Intersect<TSource>(this TSource[] c, TSource[] seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, ArrayEnumerator<TSource>, HashSetEnumerator<TSource>>> Intersect<TSource>(this TSource[] c, HashSet<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, ArrayEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Intersect<TSource>(this TSource[] c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
        public static RefLinqEnumerable<TSource, Intersect<TSource, HashSetEnumerator<TSource>, TSecondEnumerator>> Intersect<TSource, TSecondEnumerator>(this HashSet<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Intersect(seq2);
        public static RefLinqEnumerable<TSource, Intersect<TSource, HashSetEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Intersect<TSource>(this HashSet<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, HashSetEnumerator<TSource>, ArrayEnumerator<TSource>>> Intersect<TSource>(this HashSet<TSource> c, TSource[] seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, HashSetEnumerator<TSource>, HashSetEnumerator<TSource>>> Intersect<TSource>(this HashSet<TSource> c, HashSet<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, HashSetEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Intersect<TSource>(this HashSet<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
        public static RefLinqEnumerable<TSource, Intersect<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondEnumerator>> Intersect<TSource, TSecondEnumerator>(this MultiHashSetWrapper<TSource> c, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => Build(c).Intersect(seq2);
        public static RefLinqEnumerable<TSource, Intersect<TSource, MultiHashSetWrapperEnumerator<TSource>, IReadOnlyListEnumerator<TSource>>> Intersect<TSource>(this MultiHashSetWrapper<TSource> c, IReadOnlyList<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, MultiHashSetWrapperEnumerator<TSource>, ArrayEnumerator<TSource>>> Intersect<TSource>(this MultiHashSetWrapper<TSource> c, TSource[] seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, MultiHashSetWrapperEnumerator<TSource>, HashSetEnumerator<TSource>>> Intersect<TSource>(this MultiHashSetWrapper<TSource> c, HashSet<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<TSource, Intersect<TSource, MultiHashSetWrapperEnumerator<TSource>, MultiHashSetWrapperEnumerator<TSource>>> Intersect<TSource>(this MultiHashSetWrapper<TSource> c, MultiHashSetWrapper<TSource> seq2)
            => Build(c).Intersect(Build(seq2));
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Intersect<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondEnumerator>> Intersect<TSource1, TSource2, TSecondEnumerator>(this Dictionary<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Intersect(seq2);
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Intersect<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Intersect<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Intersect<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Intersect<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, MultiDictionaryWrapper<TSource1, TSource2> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Intersect<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TSecondEnumerator>> Intersect<TSource1, TSource2, TSecondEnumerator>(this MultiDictionaryWrapper<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Intersect(seq2);
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
// TODO: Dictionary not supported for Intersect.
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Intersect<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Intersect<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Intersect<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>>> Intersect<TSource1, TSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, MultiDictionaryWrapper<TSource1, TSource2> seq2)
            => Build(c).Intersect(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondInput), Zip<TSource, IReadOnlyListEnumerator<TSource>, TSecondInput, TSecondEnumerator>> Zip<TSource, TSecondInput, TSecondEnumerator>(this IReadOnlyList<TSource> c, RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => Build(c).Zip(seq2);
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, IReadOnlyListEnumerator<TSource>, TSecondSource, IReadOnlyListEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this IReadOnlyList<TSource> c, IReadOnlyList<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, IReadOnlyListEnumerator<TSource>, TSecondSource, ArrayEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this IReadOnlyList<TSource> c, TSecondSource[] seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, IReadOnlyListEnumerator<TSource>, TSecondSource, HashSetEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this IReadOnlyList<TSource> c, HashSet<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, IReadOnlyListEnumerator<TSource>, TSecondSource, MultiHashSetWrapperEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this IReadOnlyList<TSource> c, MultiHashSetWrapper<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
        public static RefLinqEnumerable<(TSource, TSecondInput), Zip<TSource, ArrayEnumerator<TSource>, TSecondInput, TSecondEnumerator>> Zip<TSource, TSecondInput, TSecondEnumerator>(this TSource[] c, RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => Build(c).Zip(seq2);
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, ArrayEnumerator<TSource>, TSecondSource, IReadOnlyListEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this TSource[] c, IReadOnlyList<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, ArrayEnumerator<TSource>, TSecondSource, ArrayEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this TSource[] c, TSecondSource[] seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, ArrayEnumerator<TSource>, TSecondSource, HashSetEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this TSource[] c, HashSet<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, ArrayEnumerator<TSource>, TSecondSource, MultiHashSetWrapperEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this TSource[] c, MultiHashSetWrapper<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
        public static RefLinqEnumerable<(TSource, TSecondInput), Zip<TSource, HashSetEnumerator<TSource>, TSecondInput, TSecondEnumerator>> Zip<TSource, TSecondInput, TSecondEnumerator>(this HashSet<TSource> c, RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => Build(c).Zip(seq2);
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, HashSetEnumerator<TSource>, TSecondSource, IReadOnlyListEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this HashSet<TSource> c, IReadOnlyList<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, HashSetEnumerator<TSource>, TSecondSource, ArrayEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this HashSet<TSource> c, TSecondSource[] seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, HashSetEnumerator<TSource>, TSecondSource, HashSetEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this HashSet<TSource> c, HashSet<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, HashSetEnumerator<TSource>, TSecondSource, MultiHashSetWrapperEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this HashSet<TSource> c, MultiHashSetWrapper<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
        public static RefLinqEnumerable<(TSource, TSecondInput), Zip<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondInput, TSecondEnumerator>> Zip<TSource, TSecondInput, TSecondEnumerator>(this MultiHashSetWrapper<TSource> c, RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => Build(c).Zip(seq2);
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondSource, IReadOnlyListEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this MultiHashSetWrapper<TSource> c, IReadOnlyList<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondSource, ArrayEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this MultiHashSetWrapper<TSource> c, TSecondSource[] seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondSource, HashSetEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this MultiHashSetWrapper<TSource> c, HashSet<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondSource), Zip<TSource, MultiHashSetWrapperEnumerator<TSource>, TSecondSource, MultiHashSetWrapperEnumerator<TSecondSource>>> Zip<TSource, TSecondSource>(this MultiHashSetWrapper<TSource> c, MultiHashSetWrapper<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, TSecondInput), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondInput, TSecondEnumerator>> Zip<TSource1, TSource2, TSecondInput, TSecondEnumerator>(this Dictionary<TSource1, TSource2> c, RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => Build(c).Zip(seq2);
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>, DictionaryEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource1, TSource2, TSecondSource1, TSecondSource2>(this Dictionary<TSource1, TSource2> c, Dictionary<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>, MultiDictionaryWrapperEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource1, TSource2, TSecondSource1, TSecondSource2>(this Dictionary<TSource1, TSource2> c, MultiDictionaryWrapper<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, TSecondInput), Zip<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, TSecondInput, TSecondEnumerator>> Zip<TSource1, TSource2, TSecondInput, TSecondEnumerator>(this MultiDictionaryWrapper<TSource1, TSource2> c, RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => Build(c).Zip(seq2);
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
// TODO: Dictionary not supported for Zip.
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>, DictionaryEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource1, TSource2, TSecondSource1, TSecondSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, Dictionary<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>, MultiDictionaryWrapperEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource1, TSource2, TSecondSource1, TSecondSource2>(this MultiDictionaryWrapper<TSource1, TSource2> c, MultiDictionaryWrapper<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, IReadOnlyListEnumerator<TSource>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource ,U,UEnumerator>(this IReadOnlyList<TSource> c ,Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<USource, SelectMany<USource, IReadOnlyListEnumerator<USource>, Select<IReadOnlyList<USource>, Select<TSource, IReadOnlyListEnumerator<TSource>, IReadOnlyList<USource>>, RefLinqEnumerable<USource, IReadOnlyListEnumerator<USource>>>>> SelectMany<TSource, USource>(this IReadOnlyList<TSource> prev, Func<TSource, IReadOnlyList<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, IReadOnlyListEnumerator<USource>, Select<IReadOnlyList<USource>, Select<TSource, ArrayEnumerator<TSource>, IReadOnlyList<USource>>, RefLinqEnumerable<USource, IReadOnlyListEnumerator<USource>>>>> SelectMany<TSource, USource>(this TSource[] prev, Func<TSource, IReadOnlyList<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, IReadOnlyListEnumerator<USource>, Select<IReadOnlyList<USource>, Select<TSource, HashSetEnumerator<TSource>, IReadOnlyList<USource>>, RefLinqEnumerable<USource, IReadOnlyListEnumerator<USource>>>>> SelectMany<TSource, USource>(this HashSet<TSource> prev, Func<TSource, IReadOnlyList<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, IReadOnlyListEnumerator<USource>, Select<IReadOnlyList<USource>, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, IReadOnlyList<USource>>, RefLinqEnumerable<USource, IReadOnlyListEnumerator<USource>>>>> SelectMany<TSource, USource>(this MultiHashSetWrapper<TSource> prev, Func<TSource, IReadOnlyList<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, IReadOnlyListEnumerator<USource>, Select<IReadOnlyList<USource>, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, IReadOnlyList<USource>>, RefLinqEnumerable<USource, IReadOnlyListEnumerator<USource>>>>> SelectMany<TSource1, TSource2, USource>(this Dictionary<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, IReadOnlyList<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, IReadOnlyListEnumerator<USource>, Select<IReadOnlyList<USource>, Select<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, IReadOnlyList<USource>>, RefLinqEnumerable<USource, IReadOnlyListEnumerator<USource>>>>> SelectMany<TSource1, TSource2, USource>(this MultiDictionaryWrapper<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, IReadOnlyList<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, ArrayEnumerator<TSource>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource ,U,UEnumerator>(this TSource[] c ,Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<USource, SelectMany<USource, ArrayEnumerator<USource>, Select<USource[], Select<TSource, IReadOnlyListEnumerator<TSource>, USource[]>, RefLinqEnumerable<USource, ArrayEnumerator<USource>>>>> SelectMany<TSource, USource>(this IReadOnlyList<TSource> prev, Func<TSource, USource[]> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, ArrayEnumerator<USource>, Select<USource[], Select<TSource, ArrayEnumerator<TSource>, USource[]>, RefLinqEnumerable<USource, ArrayEnumerator<USource>>>>> SelectMany<TSource, USource>(this TSource[] prev, Func<TSource, USource[]> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, ArrayEnumerator<USource>, Select<USource[], Select<TSource, HashSetEnumerator<TSource>, USource[]>, RefLinqEnumerable<USource, ArrayEnumerator<USource>>>>> SelectMany<TSource, USource>(this HashSet<TSource> prev, Func<TSource, USource[]> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, ArrayEnumerator<USource>, Select<USource[], Select<TSource, MultiHashSetWrapperEnumerator<TSource>, USource[]>, RefLinqEnumerable<USource, ArrayEnumerator<USource>>>>> SelectMany<TSource, USource>(this MultiHashSetWrapper<TSource> prev, Func<TSource, USource[]> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, ArrayEnumerator<USource>, Select<USource[], Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, USource[]>, RefLinqEnumerable<USource, ArrayEnumerator<USource>>>>> SelectMany<TSource1, TSource2, USource>(this Dictionary<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, USource[]> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, ArrayEnumerator<USource>, Select<USource[], Select<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, USource[]>, RefLinqEnumerable<USource, ArrayEnumerator<USource>>>>> SelectMany<TSource1, TSource2, USource>(this MultiDictionaryWrapper<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, USource[]> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, HashSetEnumerator<TSource>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource ,U,UEnumerator>(this HashSet<TSource> c ,Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<USource, SelectMany<USource, HashSetEnumerator<USource>, Select<HashSet<USource>, Select<TSource, IReadOnlyListEnumerator<TSource>, HashSet<USource>>, RefLinqEnumerable<USource, HashSetEnumerator<USource>>>>> SelectMany<TSource, USource>(this IReadOnlyList<TSource> prev, Func<TSource, HashSet<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, HashSetEnumerator<USource>, Select<HashSet<USource>, Select<TSource, ArrayEnumerator<TSource>, HashSet<USource>>, RefLinqEnumerable<USource, HashSetEnumerator<USource>>>>> SelectMany<TSource, USource>(this TSource[] prev, Func<TSource, HashSet<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, HashSetEnumerator<USource>, Select<HashSet<USource>, Select<TSource, HashSetEnumerator<TSource>, HashSet<USource>>, RefLinqEnumerable<USource, HashSetEnumerator<USource>>>>> SelectMany<TSource, USource>(this HashSet<TSource> prev, Func<TSource, HashSet<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, HashSetEnumerator<USource>, Select<HashSet<USource>, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, HashSet<USource>>, RefLinqEnumerable<USource, HashSetEnumerator<USource>>>>> SelectMany<TSource, USource>(this MultiHashSetWrapper<TSource> prev, Func<TSource, HashSet<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, HashSetEnumerator<USource>, Select<HashSet<USource>, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, HashSet<USource>>, RefLinqEnumerable<USource, HashSetEnumerator<USource>>>>> SelectMany<TSource1, TSource2, USource>(this Dictionary<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, HashSet<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, HashSetEnumerator<USource>, Select<HashSet<USource>, Select<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, HashSet<USource>>, RefLinqEnumerable<USource, HashSetEnumerator<USource>>>>> SelectMany<TSource1, TSource2, USource>(this MultiDictionaryWrapper<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, HashSet<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource ,U,UEnumerator>(this MultiHashSetWrapper<TSource> c ,Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<USource, SelectMany<USource, MultiHashSetWrapperEnumerator<USource>, Select<MultiHashSetWrapper<USource>, Select<TSource, IReadOnlyListEnumerator<TSource>, MultiHashSetWrapper<USource>>, RefLinqEnumerable<USource, MultiHashSetWrapperEnumerator<USource>>>>> SelectMany<TSource, USource>(this IReadOnlyList<TSource> prev, Func<TSource, MultiHashSetWrapper<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, MultiHashSetWrapperEnumerator<USource>, Select<MultiHashSetWrapper<USource>, Select<TSource, ArrayEnumerator<TSource>, MultiHashSetWrapper<USource>>, RefLinqEnumerable<USource, MultiHashSetWrapperEnumerator<USource>>>>> SelectMany<TSource, USource>(this TSource[] prev, Func<TSource, MultiHashSetWrapper<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, MultiHashSetWrapperEnumerator<USource>, Select<MultiHashSetWrapper<USource>, Select<TSource, HashSetEnumerator<TSource>, MultiHashSetWrapper<USource>>, RefLinqEnumerable<USource, MultiHashSetWrapperEnumerator<USource>>>>> SelectMany<TSource, USource>(this HashSet<TSource> prev, Func<TSource, MultiHashSetWrapper<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, MultiHashSetWrapperEnumerator<USource>, Select<MultiHashSetWrapper<USource>, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, MultiHashSetWrapper<USource>>, RefLinqEnumerable<USource, MultiHashSetWrapperEnumerator<USource>>>>> SelectMany<TSource, USource>(this MultiHashSetWrapper<TSource> prev, Func<TSource, MultiHashSetWrapper<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, MultiHashSetWrapperEnumerator<USource>, Select<MultiHashSetWrapper<USource>, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, MultiHashSetWrapper<USource>>, RefLinqEnumerable<USource, MultiHashSetWrapperEnumerator<USource>>>>> SelectMany<TSource1, TSource2, USource>(this Dictionary<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, MultiHashSetWrapper<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<USource, SelectMany<USource, MultiHashSetWrapperEnumerator<USource>, Select<MultiHashSetWrapper<USource>, Select<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, MultiHashSetWrapper<USource>>, RefLinqEnumerable<USource, MultiHashSetWrapperEnumerator<USource>>>>> SelectMany<TSource1, TSource2, USource>(this MultiDictionaryWrapper<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, MultiHashSetWrapper<USource>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource1, TSource2 ,U,UEnumerator>(this Dictionary<TSource1, TSource2> c ,Func<KeyValuePair<TSource1, TSource2>, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>, Select<Dictionary<USource1, USource2>, Select<TSource, IReadOnlyListEnumerator<TSource>, Dictionary<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>>>>> SelectMany<TSource, USource1, USource2>(this IReadOnlyList<TSource> prev, Func<TSource, Dictionary<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>, Select<Dictionary<USource1, USource2>, Select<TSource, ArrayEnumerator<TSource>, Dictionary<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>>>>> SelectMany<TSource, USource1, USource2>(this TSource[] prev, Func<TSource, Dictionary<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>, Select<Dictionary<USource1, USource2>, Select<TSource, HashSetEnumerator<TSource>, Dictionary<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>>>>> SelectMany<TSource, USource1, USource2>(this HashSet<TSource> prev, Func<TSource, Dictionary<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>, Select<Dictionary<USource1, USource2>, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, Dictionary<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>>>>> SelectMany<TSource, USource1, USource2>(this MultiHashSetWrapper<TSource> prev, Func<TSource, Dictionary<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>, Select<Dictionary<USource1, USource2>, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, Dictionary<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>>>>> SelectMany<TSource1, TSource2, USource1, USource2>(this Dictionary<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, Dictionary<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>, Select<Dictionary<USource1, USource2>, Select<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, Dictionary<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>>>>> SelectMany<TSource1, TSource2, USource1, USource2>(this MultiDictionaryWrapper<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, Dictionary<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource1, TSource2 ,U,UEnumerator>(this MultiDictionaryWrapper<TSource1, TSource2> c ,Func<KeyValuePair<TSource1, TSource2>, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>, Select<MultiDictionaryWrapper<USource1, USource2>, Select<TSource, IReadOnlyListEnumerator<TSource>, MultiDictionaryWrapper<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>>>>> SelectMany<TSource, USource1, USource2>(this IReadOnlyList<TSource> prev, Func<TSource, MultiDictionaryWrapper<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>, Select<MultiDictionaryWrapper<USource1, USource2>, Select<TSource, ArrayEnumerator<TSource>, MultiDictionaryWrapper<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>>>>> SelectMany<TSource, USource1, USource2>(this TSource[] prev, Func<TSource, MultiDictionaryWrapper<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>, Select<MultiDictionaryWrapper<USource1, USource2>, Select<TSource, HashSetEnumerator<TSource>, MultiDictionaryWrapper<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>>>>> SelectMany<TSource, USource1, USource2>(this HashSet<TSource> prev, Func<TSource, MultiDictionaryWrapper<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>, Select<MultiDictionaryWrapper<USource1, USource2>, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, MultiDictionaryWrapper<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>>>>> SelectMany<TSource, USource1, USource2>(this MultiHashSetWrapper<TSource> prev, Func<TSource, MultiDictionaryWrapper<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>, Select<MultiDictionaryWrapper<USource1, USource2>, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, MultiDictionaryWrapper<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>>>>> SelectMany<TSource1, TSource2, USource1, USource2>(this Dictionary<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapper<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>, Select<MultiDictionaryWrapper<USource1, USource2>, Select<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapperEnumerator<TSource1, TSource2>, MultiDictionaryWrapper<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>>>>> SelectMany<TSource1, TSource2, USource1, USource2>(this MultiDictionaryWrapper<TSource1, TSource2> prev, Func<KeyValuePair<TSource1, TSource2>, MultiDictionaryWrapper<USource1, USource2>> func)
            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();

    }
    public partial struct RefLinqEnumerable<TSource, TPrevious>
    {
        public int Count(Func<TSource, bool> pred)
            => this.Where(pred).Count();
        public bool Any(Func<TSource, bool> pred)
            => this.Where(pred).Any();
        public TSource Single(Func<TSource, bool> pred)
            => this.Where(pred).Single();
        public TSource SingleOrDefault(Func<TSource, bool> pred)
            => this.Where(pred).SingleOrDefault();
        public TSource First(Func<TSource, bool> pred)
            => this.Where(pred).First();
        public TSource FirstOrDefault(Func<TSource, bool> pred)
            => this.Where(pred).FirstOrDefault();
        public TSource Last(Func<TSource, bool> pred)
            => this.Where(pred).Last();
        public TSource LastOrDefault(Func<TSource, bool> pred)
            => this.Where(pred).LastOrDefault();
        public TSource Max(Func<TSource, bool> pred)
            => this.Where(pred).Max();
        public TSource Min(Func<TSource, bool> pred)
            => this.Where(pred).Min();
        public TSource Average(Func<TSource, bool> pred)
            => this.Where(pred).Average();
        public TSource Sum(Func<TSource, bool> pred)
            => this.Where(pred).Sum();
        public TSource Multiply(Func<TSource, bool> pred)
            => this.Where(pred).Multiply();
        public RefLinqEnumerable<TSource, Where<TSource, TPrevious>> Where(Func<TSource, bool> predicate)
            => new RefLinqEnumerable<TSource, Where<TSource, TPrevious>>(new Where<TSource, TPrevious>(this.enumerator, predicate));
        public RefLinqEnumerable<TSource, Skip<TSource, TPrevious>> Skip(int skip)
            => new RefLinqEnumerable<TSource, Skip<TSource, TPrevious>>(new Skip<TSource, TPrevious>(this.enumerator, skip));
        public RefLinqEnumerable<TSource, Take<TSource, TPrevious>> Take(int take)
            => new RefLinqEnumerable<TSource, Take<TSource, TPrevious>>(new Take<TSource, TPrevious>(this.enumerator, take));
        public RefLinqEnumerable<TSource, Reverse<TSource, TPrevious>> Reverse()
            => new RefLinqEnumerable<TSource, Reverse<TSource, TPrevious>>(new Reverse<TSource, TPrevious>(this.enumerator));
        public RefLinqEnumerable<TSource, Append<TSource, TPrevious>> Append(TSource toAppend)
            => new RefLinqEnumerable<TSource, Append<TSource, TPrevious>>(new Append<TSource, TPrevious>(this.enumerator, toAppend));
        public RefLinqEnumerable<TSource, Repeat<TSource, TPrevious>> Repeat(int times)
            => new RefLinqEnumerable<TSource, Repeat<TSource, TPrevious>>(new Repeat<TSource, TPrevious>(this.enumerator, times));
        public RefLinqEnumerable<TSource, Prepend<TSource, TPrevious>> Prepend(TSource toPrepend)
            => new RefLinqEnumerable<TSource, Prepend<TSource, TPrevious>>(new Prepend<TSource, TPrevious>(this.enumerator, toPrepend));
        public RefLinqEnumerable<TSource, OrderBy<TSource, TPrevious, TOrderByKey>> OrderBy<TOrderByKey>(Func<TSource, TOrderByKey> keySelector)
            => new RefLinqEnumerable<TSource, OrderBy<TSource, TPrevious, TOrderByKey>>(new OrderBy<TSource, TPrevious, TOrderByKey>(this.enumerator, keySelector));
        public RefLinqEnumerable<TSource, DistinctBy<TSource, TPrevious, TDistinctByKey>> DistinctBy<TDistinctByKey>(Func<TSource, TDistinctByKey> keySelector)
            => new RefLinqEnumerable<TSource, DistinctBy<TSource, TPrevious, TDistinctByKey>>(new DistinctBy<TSource, TPrevious, TDistinctByKey>(this.enumerator, keySelector));
        public RefLinqEnumerable<TSource, Distinct<TSource, TPrevious>> Distinct()
            => new RefLinqEnumerable<TSource, Distinct<TSource, TPrevious>>(new Distinct<TSource, TPrevious>(this.enumerator));
        public RefLinqEnumerable<TOutput, Select<TSource, TPrevious, TOutput>> Select<TOutput>(Func<TSource, TOutput> map)
            => new RefLinqEnumerable<TOutput, Select<TSource, TPrevious, TOutput>>(new Select<TSource, TPrevious, TOutput>(this.enumerator, map));
        public RefLinqEnumerable<TOutput, Cast<TSource, TPrevious, TOutput>> Cast<TOutput>()
            => new RefLinqEnumerable<TOutput, Cast<TSource, TPrevious, TOutput>>(new Cast<TSource, TPrevious, TOutput>(this.enumerator));
        public RefLinqEnumerable<TOutput, OfType<TSource, TPrevious, TOutput>> OfType<TOutput>()
            => new RefLinqEnumerable<TOutput, OfType<TSource, TPrevious, TOutput>>(new OfType<TSource, TPrevious, TOutput>(this.enumerator));
        public RefLinqEnumerable<TSource, Union<TSource, TPrevious, TSecondEnumerator>> Union<TSecondEnumerator>(RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Union<TSource, TPrevious, TSecondEnumerator>>(new Union<TSource, TPrevious, TSecondEnumerator>(this.enumerator, seq2));
        public RefLinqEnumerable<TSource, Concat<TSource, TPrevious, TSecondEnumerator>> Concat<TSecondEnumerator>(RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Concat<TSource, TPrevious, TSecondEnumerator>>(new Concat<TSource, TPrevious, TSecondEnumerator>(this.enumerator, seq2));
        public RefLinqEnumerable<TSource, Except<TSource, TPrevious, TSecondEnumerator>> Except<TSecondEnumerator>(RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Except<TSource, TPrevious, TSecondEnumerator>>(new Except<TSource, TPrevious, TSecondEnumerator>(this.enumerator, seq2));
        public RefLinqEnumerable<TSource, Intersect<TSource, TPrevious, TSecondEnumerator>> Intersect<TSecondEnumerator>(RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Intersect<TSource, TPrevious, TSecondEnumerator>>(new Intersect<TSource, TPrevious, TSecondEnumerator>(this.enumerator, seq2));
        public RefLinqEnumerable<(TSource, TSecondInput), Zip<TSource, TPrevious, TSecondInput, TSecondEnumerator>> Zip<TSecondInput, TSecondEnumerator>(RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => new RefLinqEnumerable<(TSource, TSecondInput), Zip<TSource, TPrevious, TSecondInput, TSecondEnumerator>>(new Zip<TSource, TPrevious, TSecondInput, TSecondEnumerator>(this.enumerator, seq2));
        public RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, TPrevious, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<U, UEnumerator>(Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => this.Select(func).SelectMany();
        public RefLinqEnumerable<USource, SelectMany<USource, IReadOnlyListEnumerator<USource>, Select<IReadOnlyList<USource>, Select<TSource, TPrevious, IReadOnlyList<USource>>, RefLinqEnumerable<USource, IReadOnlyListEnumerator<USource>>>>> SelectMany<USource>(Func<TSource, IReadOnlyList<USource>> func)
            => this.Select(func).Select(a => GeneratedExtensions.Build(a)).SelectMany();
        public RefLinqEnumerable<USource, SelectMany<USource, ArrayEnumerator<USource>, Select<USource[], Select<TSource, TPrevious, USource[]>, RefLinqEnumerable<USource, ArrayEnumerator<USource>>>>> SelectMany<USource>(Func<TSource, USource[]> func)
            => this.Select(func).Select(a => GeneratedExtensions.Build(a)).SelectMany();
        public RefLinqEnumerable<USource, SelectMany<USource, HashSetEnumerator<USource>, Select<HashSet<USource>, Select<TSource, TPrevious, HashSet<USource>>, RefLinqEnumerable<USource, HashSetEnumerator<USource>>>>> SelectMany<USource>(Func<TSource, HashSet<USource>> func)
            => this.Select(func).Select(a => GeneratedExtensions.Build(a)).SelectMany();
        public RefLinqEnumerable<USource, SelectMany<USource, MultiHashSetWrapperEnumerator<USource>, Select<MultiHashSetWrapper<USource>, Select<TSource, TPrevious, MultiHashSetWrapper<USource>>, RefLinqEnumerable<USource, MultiHashSetWrapperEnumerator<USource>>>>> SelectMany<USource>(Func<TSource, MultiHashSetWrapper<USource>> func)
            => this.Select(func).Select(a => GeneratedExtensions.Build(a)).SelectMany();
        public RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>, Select<Dictionary<USource1, USource2>, Select<TSource, TPrevious, Dictionary<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>>>>> SelectMany<USource1, USource2>(Func<TSource, Dictionary<USource1, USource2>> func)
            => this.Select(func).Select(a => GeneratedExtensions.Build(a)).SelectMany();
        public RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>, Select<MultiDictionaryWrapper<USource1, USource2>, Select<TSource, TPrevious, MultiDictionaryWrapper<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, MultiDictionaryWrapperEnumerator<USource1, USource2>>>>> SelectMany<USource1, USource2>(Func<TSource, MultiDictionaryWrapper<USource1, USource2>> func)
            => this.Select(func).Select(a => GeneratedExtensions.Build(a)).SelectMany();

    }
}
