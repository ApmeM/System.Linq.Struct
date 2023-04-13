using System.Collections.Generic;
namespace System.Linq.Struct
{
    public static partial class GeneratedExtensions
    {
#region Build
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
#endregion
#region Add Where predicate to known finalizers that needs them
        public static int Count<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Count();
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
        public static bool Any<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Any();
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
        public static TSource Single<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Single();
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
        public static TSource SingleOrDefault<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).SingleOrDefault();
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
        public static TSource First<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).First();
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
        public static TSource FirstOrDefault<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).FirstOrDefault();
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
        public static TSource Last<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Last();
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
        public static TSource LastOrDefault<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).LastOrDefault();
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
        public static TSource Max<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Max();
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
        public static TSource Min<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Min();
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
        public static TSource Average<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Average();
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
        public static TSource Sum<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Sum();
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
        public static TSource Multiply<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)
            where TEnumerator : IRefEnumerator<TSource>
            => seq.Where(pred).Multiply();
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
#endregion
#region Add basic extensions for known finalizers
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
#endregion
#region Add basic extensions for known enumerables
        public static RefLinqEnumerable<TSource, Where<TSource, TPrevious>> Where<TSource, TPrevious>(this RefLinqEnumerable<TSource, TPrevious> prev, Func<TSource, bool> predicate)
            where TPrevious : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Where<TSource, TPrevious>>(new Where<TSource, TPrevious>(prev.enumerator, predicate));
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
        public static RefLinqEnumerable<TSource, Skip<TSource, TPrevious>> Skip<TSource, TPrevious>(this RefLinqEnumerable<TSource, TPrevious> prev, int skip)
            where TPrevious : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Skip<TSource, TPrevious>>(new Skip<TSource, TPrevious>(prev.enumerator, skip));
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
        public static RefLinqEnumerable<TSource, Take<TSource, TPrevious>> Take<TSource, TPrevious>(this RefLinqEnumerable<TSource, TPrevious> prev, int take)
            where TPrevious : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Take<TSource, TPrevious>>(new Take<TSource, TPrevious>(prev.enumerator, take));
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
        public static RefLinqEnumerable<TSource, Append<TSource, TPrevious>> Append<TSource, TPrevious>(this RefLinqEnumerable<TSource, TPrevious> prev, TSource toAppend)
            where TPrevious : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Append<TSource, TPrevious>>(new Append<TSource, TPrevious>(prev.enumerator, toAppend));
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
        public static RefLinqEnumerable<TSource, Prepend<TSource, TPrevious>> Prepend<TSource, TPrevious>(this RefLinqEnumerable<TSource, TPrevious> prev, TSource toPrepend)
            where TPrevious : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Prepend<TSource, TPrevious>>(new Prepend<TSource, TPrevious>(prev.enumerator, toPrepend));
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
        public static RefLinqEnumerable<TSource, OrderBy<TSource, TPrevious, TOrderByKey>> OrderBy<TSource, TPrevious, TOrderByKey>(this RefLinqEnumerable<TSource, TPrevious> prev, Func<TSource, TOrderByKey> keySelector)
            where TPrevious : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, OrderBy<TSource, TPrevious, TOrderByKey>>(new OrderBy<TSource, TPrevious, TOrderByKey>(prev.enumerator, keySelector));
        public static RefLinqEnumerable<TSource, OrderBy<TSource, IReadOnlyListEnumerator<TSource>, TOrderByKey>> OrderBy<TSource, TOrderByKey>(this IReadOnlyList<TSource> c, Func<TSource, TOrderByKey> keySelector)
            => Build(c).OrderBy(keySelector);
        public static RefLinqEnumerable<TSource, OrderBy<TSource, ArrayEnumerator<TSource>, TOrderByKey>> OrderBy<TSource, TOrderByKey>(this TSource[] c, Func<TSource, TOrderByKey> keySelector)
            => Build(c).OrderBy(keySelector);
        public static RefLinqEnumerable<TSource, OrderBy<TSource, HashSetEnumerator<TSource>, TOrderByKey>> OrderBy<TSource, TOrderByKey>(this HashSet<TSource> c, Func<TSource, TOrderByKey> keySelector)
            => Build(c).OrderBy(keySelector);
        public static RefLinqEnumerable<TSource, OrderBy<TSource, MultiHashSetWrapperEnumerator<TSource>, TOrderByKey>> OrderBy<TSource, TOrderByKey>(this MultiHashSetWrapper<TSource> c, Func<TSource, TOrderByKey> keySelector)
            => Build(c).OrderBy(keySelector);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, OrderBy<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TOrderByKey>> OrderBy<TSource1, TSource2, TOrderByKey>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TOrderByKey> keySelector)
            => Build(c).OrderBy(keySelector);
        public static RefLinqEnumerable<TOutput, Select<TSource, TPrevious, TOutput>> Select<TSource, TPrevious, TOutput>(this RefLinqEnumerable<TSource, TPrevious> prev, Func<TSource, TOutput> map)
            where TPrevious : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TOutput, Select<TSource, TPrevious, TOutput>>(new Select<TSource, TPrevious, TOutput>(prev.enumerator, map));
        public static RefLinqEnumerable<TOutput, Select<TSource, IReadOnlyListEnumerator<TSource>, TOutput>> Select<TSource, TOutput>(this IReadOnlyList<TSource> c, Func<TSource, TOutput> map)
            => Build(c).Select(map);
        public static RefLinqEnumerable<TOutput, Select<TSource, ArrayEnumerator<TSource>, TOutput>> Select<TSource, TOutput>(this TSource[] c, Func<TSource, TOutput> map)
            => Build(c).Select(map);
        public static RefLinqEnumerable<TOutput, Select<TSource, HashSetEnumerator<TSource>, TOutput>> Select<TSource, TOutput>(this HashSet<TSource> c, Func<TSource, TOutput> map)
            => Build(c).Select(map);
        public static RefLinqEnumerable<TOutput, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, TOutput>> Select<TSource, TOutput>(this MultiHashSetWrapper<TSource> c, Func<TSource, TOutput> map)
            => Build(c).Select(map);
        public static RefLinqEnumerable<TOutput, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TOutput>> Select<TSource1, TSource2, TOutput>(this Dictionary<TSource1, TSource2> c, Func<KeyValuePair<TSource1, TSource2>, TOutput> map)
            => Build(c).Select(map);
#endregion
#region Add basic extensions for known enumerables
        public static RefLinqEnumerable<TSource, Concat<TSource, TPrevious, TSecondEnumerator>> Concat<TSource, TPrevious, TSecondEnumerator>(this RefLinqEnumerable<TSource, TPrevious> prev, RefLinqEnumerable<TSource, TSecondEnumerator> seq2)
            where TPrevious : IRefEnumerator<TSource> where TSecondEnumerator : IRefEnumerator<TSource>
            => new RefLinqEnumerable<TSource, Concat<TSource, TPrevious, TSecondEnumerator>>(new Concat<TSource, TPrevious, TSecondEnumerator>(prev.enumerator, seq2));
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
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Concat<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondEnumerator>> Concat<TSource1, TSource2, TSecondEnumerator>(this Dictionary<TSource1, TSource2> c, RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<KeyValuePair<TSource1, TSource2>>
            => Build(c).Concat(seq2);
        public static RefLinqEnumerable<KeyValuePair<TSource1, TSource2>, Concat<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>>> Concat<TSource1, TSource2>(this Dictionary<TSource1, TSource2> c, Dictionary<TSource1, TSource2> seq2)
            => Build(c).Concat(Build(seq2));
        public static RefLinqEnumerable<(TSource, TSecondInput), Zip<TSource, TPrevious, TSecondInput, TSecondEnumerator>> Zip<TSource, TPrevious, TSecondInput, TSecondEnumerator>(this RefLinqEnumerable<TSource, TPrevious> prev, RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TPrevious : IRefEnumerator<TSource> where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => new RefLinqEnumerable<(TSource, TSecondInput), Zip<TSource, TPrevious, TSecondInput, TSecondEnumerator>>(new Zip<TSource, TPrevious, TSecondInput, TSecondEnumerator>(prev.enumerator, seq2));
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
        public static RefLinqEnumerable<(TSource, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<TSource, IReadOnlyListEnumerator<TSource>, KeyValuePair<TSecondSource1, TSecondSource2>, DictionaryEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource, TSecondSource1, TSecondSource2>(this IReadOnlyList<TSource> c, Dictionary<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
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
        public static RefLinqEnumerable<(TSource, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<TSource, ArrayEnumerator<TSource>, KeyValuePair<TSecondSource1, TSecondSource2>, DictionaryEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource, TSecondSource1, TSecondSource2>(this TSource[] c, Dictionary<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
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
        public static RefLinqEnumerable<(TSource, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<TSource, HashSetEnumerator<TSource>, KeyValuePair<TSecondSource1, TSecondSource2>, DictionaryEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource, TSecondSource1, TSecondSource2>(this HashSet<TSource> c, Dictionary<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
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
        public static RefLinqEnumerable<(TSource, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<TSource, MultiHashSetWrapperEnumerator<TSource>, KeyValuePair<TSecondSource1, TSecondSource2>, DictionaryEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource, TSecondSource1, TSecondSource2>(this MultiHashSetWrapper<TSource> c, Dictionary<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, TSecondInput), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondInput, TSecondEnumerator>> Zip<TSource1, TSource2, TSecondInput, TSecondEnumerator>(this Dictionary<TSource1, TSource2> c, RefLinqEnumerable<TSecondInput, TSecondEnumerator> seq2)
            where TSecondEnumerator : IRefEnumerator<TSecondInput>
            => Build(c).Zip(seq2);
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, TSecondSource), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondSource, IReadOnlyListEnumerator<TSecondSource>>> Zip<TSource1, TSource2, TSecondSource>(this Dictionary<TSource1, TSource2> c, IReadOnlyList<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, TSecondSource), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondSource, ArrayEnumerator<TSecondSource>>> Zip<TSource1, TSource2, TSecondSource>(this Dictionary<TSource1, TSource2> c, TSecondSource[] seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, TSecondSource), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondSource, HashSetEnumerator<TSecondSource>>> Zip<TSource1, TSource2, TSecondSource>(this Dictionary<TSource1, TSource2> c, HashSet<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, TSecondSource), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, TSecondSource, MultiHashSetWrapperEnumerator<TSecondSource>>> Zip<TSource1, TSource2, TSecondSource>(this Dictionary<TSource1, TSource2> c, MultiHashSetWrapper<TSecondSource> seq2)
            => Build(c).Zip(Build(seq2));
        public static RefLinqEnumerable<(KeyValuePair<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>), Zip<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, KeyValuePair<TSecondSource1, TSecondSource2>, DictionaryEnumerator<TSecondSource1, TSecondSource2>>> Zip<TSource1, TSource2, TSecondSource1, TSecondSource2>(this Dictionary<TSource1, TSource2> c, Dictionary<TSecondSource1, TSecondSource2> seq2)
            => Build(c).Zip(Build(seq2));
#endregion
#region SelectMany extensions
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<T, TPrevious, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<T, TPrevious, U, UEnumerator>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, RefLinqEnumerable<U, UEnumerator>> func)
            where TPrevious : IRefEnumerator<T>
            where UEnumerator : IRefEnumerator<U>
            => prev.Select(func).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, IReadOnlyListEnumerator<TSource>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource ,U,UEnumerator>(this IReadOnlyList<TSource> c ,Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<USource, SelectMany<USource, IReadOnlyListEnumerator<USource>, Select<IReadOnlyList<USource>, Select<T, TPrevious, IReadOnlyList<USource>>, RefLinqEnumerable<USource, IReadOnlyListEnumerator<USource>>>>> SelectMany<T, TPrevious, USource>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, IReadOnlyList<USource>> func)
            where TPrevious : IRefEnumerator<T>
            => prev.Select(func).Select(a => Build(a)).SelectMany();
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
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, ArrayEnumerator<TSource>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource ,U,UEnumerator>(this TSource[] c ,Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<USource, SelectMany<USource, ArrayEnumerator<USource>, Select<USource[], Select<T, TPrevious, USource[]>, RefLinqEnumerable<USource, ArrayEnumerator<USource>>>>> SelectMany<T, TPrevious, USource>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, USource[]> func)
            where TPrevious : IRefEnumerator<T>
            => prev.Select(func).Select(a => Build(a)).SelectMany();
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
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, HashSetEnumerator<TSource>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource ,U,UEnumerator>(this HashSet<TSource> c ,Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<USource, SelectMany<USource, HashSetEnumerator<USource>, Select<HashSet<USource>, Select<T, TPrevious, HashSet<USource>>, RefLinqEnumerable<USource, HashSetEnumerator<USource>>>>> SelectMany<T, TPrevious, USource>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, HashSet<USource>> func)
            where TPrevious : IRefEnumerator<T>
            => prev.Select(func).Select(a => Build(a)).SelectMany();
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
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, MultiHashSetWrapperEnumerator<TSource>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource ,U,UEnumerator>(this MultiHashSetWrapper<TSource> c ,Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<USource, SelectMany<USource, MultiHashSetWrapperEnumerator<USource>, Select<MultiHashSetWrapper<USource>, Select<T, TPrevious, MultiHashSetWrapper<USource>>, RefLinqEnumerable<USource, MultiHashSetWrapperEnumerator<USource>>>>> SelectMany<T, TPrevious, USource>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, MultiHashSetWrapper<USource>> func)
            where TPrevious : IRefEnumerator<T>
            => prev.Select(func).Select(a => Build(a)).SelectMany();
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
        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<KeyValuePair<TSource1, TSource2>, DictionaryEnumerator<TSource1, TSource2>, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<TSource1, TSource2 ,U,UEnumerator>(this Dictionary<TSource1, TSource2> c ,Func<KeyValuePair<TSource1, TSource2>, RefLinqEnumerable<U, UEnumerator>> func)
            where UEnumerator : IRefEnumerator<U>
            => Build(c).SelectMany(func);
        public static RefLinqEnumerable<KeyValuePair<USource1, USource2>, SelectMany<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>, Select<Dictionary<USource1, USource2>, Select<T, TPrevious, Dictionary<USource1, USource2>>, RefLinqEnumerable<KeyValuePair<USource1, USource2>, DictionaryEnumerator<USource1, USource2>>>>> SelectMany<T, TPrevious, USource1, USource2>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, Dictionary<USource1, USource2>> func)
            where TPrevious : IRefEnumerator<T>
            => prev.Select(func).Select(a => Build(a)).SelectMany();
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
#endregion
    }
}
