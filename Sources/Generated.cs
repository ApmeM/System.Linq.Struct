using System.Collections.Generic;
namespace System.Linq.Struct
{
    public static partial class GeneratedExtensions
    {
        public static int Count<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Count();
        public static bool Any<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Any();
        public static T Single<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Single();
        public static T SingleOrDefault<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).SingleOrDefault();
        public static T First<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).First();
        public static T FirstOrDefault<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).FirstOrDefault();
        public static T Last<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Last();
        public static T LastOrDefault<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).LastOrDefault();
        public static T Max<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Max();
        public static T Min<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Min();
        public static T Average<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Average();
        public static T Sum<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Sum();
        public static T Multiply<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)
            where TEnumerator : IRefEnumerator<T>
            => seq.Where(pred).Multiply();
        public static RefLinqEnumerable<T, Where<T, TPrevious >> Where<T, TPrevious>(this RefLinqEnumerable<T, TPrevious> prev ,Func<T, bool> predicate)
            where TPrevious : IRefEnumerator<T> 
            => new RefLinqEnumerable<T, Where<T, TPrevious>>(new Where<T, TPrevious>(prev.enumerator ,predicate));
        public static RefLinqEnumerable<T, Skip<T, TPrevious >> Skip<T, TPrevious>(this RefLinqEnumerable<T, TPrevious> prev ,int skip)
            where TPrevious : IRefEnumerator<T> 
            => new RefLinqEnumerable<T, Skip<T, TPrevious>>(new Skip<T, TPrevious>(prev.enumerator ,skip));
        public static RefLinqEnumerable<T, Take<T, TPrevious >> Take<T, TPrevious>(this RefLinqEnumerable<T, TPrevious> prev ,int take)
            where TPrevious : IRefEnumerator<T> 
            => new RefLinqEnumerable<T, Take<T, TPrevious>>(new Take<T, TPrevious>(prev.enumerator ,take));
        public static RefLinqEnumerable<T, Append<T, TPrevious >> Append<T, TPrevious>(this RefLinqEnumerable<T, TPrevious> prev ,T toAppend)
            where TPrevious : IRefEnumerator<T> 
            => new RefLinqEnumerable<T, Append<T, TPrevious>>(new Append<T, TPrevious>(prev.enumerator ,toAppend));
        public static RefLinqEnumerable<T, Prepend<T, TPrevious >> Prepend<T, TPrevious>(this RefLinqEnumerable<T, TPrevious> prev ,T toPrepend)
            where TPrevious : IRefEnumerator<T> 
            => new RefLinqEnumerable<T, Prepend<T, TPrevious>>(new Prepend<T, TPrevious>(prev.enumerator ,toPrepend));
        public static RefLinqEnumerable<T, OrderBy<T, TPrevious ,TKey>> OrderBy<T, TPrevious,TKey>(this RefLinqEnumerable<T, TPrevious> prev ,Func<T, TKey> keySelector)
            where TPrevious : IRefEnumerator<T> 
            => new RefLinqEnumerable<T, OrderBy<T, TPrevious,TKey>>(new OrderBy<T, TPrevious,TKey>(prev.enumerator ,keySelector));
        public static RefLinqEnumerable<T, Concat<T, TPrevious ,TEnumerator2>> Concat<T, TPrevious,TEnumerator2>(this RefLinqEnumerable<T, TPrevious> prev ,RefLinqEnumerable<T, TEnumerator2> seq2)
            where TPrevious : IRefEnumerator<T> where TEnumerator2 : IRefEnumerator<T>
            => new RefLinqEnumerable<T, Concat<T, TPrevious,TEnumerator2>>(new Concat<T, TPrevious,TEnumerator2>(prev.enumerator ,seq2.enumerator));
        public static RefLinqEnumerable<(T,T2), Zip<T, TPrevious ,T2,TEnumerator2>> Zip<T, TPrevious,T2,TEnumerator2>(this RefLinqEnumerable<T, TPrevious> prev ,RefLinqEnumerable<T2, TEnumerator2> seq2)
            where TPrevious : IRefEnumerator<T> where TEnumerator2 : IRefEnumerator<T2>
            => new RefLinqEnumerable<(T,T2), Zip<T, TPrevious,T2,TEnumerator2>>(new Zip<T, TPrevious,T2,TEnumerator2>(prev.enumerator ,seq2.enumerator));
        public static RefLinqEnumerable<U, Select<T, TPrevious ,U>> Select<T, TPrevious,U>(this RefLinqEnumerable<T, TPrevious> prev ,Func<T, U> map)
            where TPrevious : IRefEnumerator<T> 
            => new RefLinqEnumerable<U, Select<T, TPrevious,U>>(new Select<T, TPrevious,U>(prev.enumerator ,map));
        public static T MaxBy<T ,T2>(this IReadOnlyList<T> c ,Func<T, T2> keySelector)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).MaxBy(keySelector);
        public static T MaxBy<T ,T2>(this T[] c ,Func<T, T2> keySelector)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).MaxBy(keySelector);
        public static T MaxBy<T ,T2>(this HashSet<T> c ,Func<T, T2> keySelector)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).MaxBy(keySelector);
        public static T MaxBy<T ,T2>(this MultiHashSetWrapper<T> c ,Func<T, T2> keySelector)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).MaxBy(keySelector);
        public static T MinBy<T ,T2>(this IReadOnlyList<T> c ,Func<T, T2> keySelector)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).MinBy(keySelector);
        public static T MinBy<T ,T2>(this T[] c ,Func<T, T2> keySelector)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).MinBy(keySelector);
        public static T MinBy<T ,T2>(this HashSet<T> c ,Func<T, T2> keySelector)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).MinBy(keySelector);
        public static T MinBy<T ,T2>(this MultiHashSetWrapper<T> c ,Func<T, T2> keySelector)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).MinBy(keySelector);
        public static bool All<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).All(pred);
        public static bool All<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).All(pred);
        public static bool All<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).All(pred);
        public static bool All<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).All(pred);
        public static bool Contains<T >(this IReadOnlyList<T> c ,T toFind)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Contains(toFind);
        public static bool Contains<T >(this T[] c ,T toFind)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Contains(toFind);
        public static bool Contains<T >(this HashSet<T> c ,T toFind)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Contains(toFind);
        public static bool Contains<T >(this MultiHashSetWrapper<T> c ,T toFind)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Contains(toFind);
        public static T Aggregate<T >(this IReadOnlyList<T> c ,Func<T, T, T> agg)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Aggregate(agg);
        public static T Aggregate<T >(this T[] c ,Func<T, T, T> agg)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Aggregate(agg);
        public static T Aggregate<T >(this HashSet<T> c ,Func<T, T, T> agg)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Aggregate(agg);
        public static T Aggregate<T >(this MultiHashSetWrapper<T> c ,Func<T, T, T> agg)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Aggregate(agg);
        public static TAccumulate Aggregate<T ,TAccumulate>(this IReadOnlyList<T> c ,TAccumulate acc,Func<TAccumulate, T, TAccumulate> agg)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Aggregate(acc,agg);
        public static TAccumulate Aggregate<T ,TAccumulate>(this T[] c ,TAccumulate acc,Func<TAccumulate, T, TAccumulate> agg)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Aggregate(acc,agg);
        public static TAccumulate Aggregate<T ,TAccumulate>(this HashSet<T> c ,TAccumulate acc,Func<TAccumulate, T, TAccumulate> agg)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Aggregate(acc,agg);
        public static TAccumulate Aggregate<T ,TAccumulate>(this MultiHashSetWrapper<T> c ,TAccumulate acc,Func<TAccumulate, T, TAccumulate> agg)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Aggregate(acc,agg);
        public static int Count<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Count();
        public static int Count<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Count();
        public static int Count<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Count();
        public static int Count<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Count();
        public static int Count<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Count(pred);
        public static int Count<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Count(pred);
        public static int Count<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Count(pred);
        public static int Count<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Count(pred);
        public static bool Any<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Any();
        public static bool Any<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Any();
        public static bool Any<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Any();
        public static bool Any<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Any();
        public static bool Any<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Any(pred);
        public static bool Any<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Any(pred);
        public static bool Any<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Any(pred);
        public static bool Any<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Any(pred);
        public static T Single<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Single();
        public static T Single<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Single();
        public static T Single<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Single();
        public static T Single<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Single();
        public static T Single<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Single(pred);
        public static T Single<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Single(pred);
        public static T Single<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Single(pred);
        public static T Single<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Single(pred);
        public static T SingleOrDefault<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).SingleOrDefault();
        public static T SingleOrDefault<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).SingleOrDefault();
        public static T SingleOrDefault<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).SingleOrDefault();
        public static T SingleOrDefault<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).SingleOrDefault();
        public static T SingleOrDefault<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).SingleOrDefault(pred);
        public static T SingleOrDefault<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).SingleOrDefault(pred);
        public static T SingleOrDefault<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).SingleOrDefault(pred);
        public static T SingleOrDefault<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).SingleOrDefault(pred);
        public static T First<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).First();
        public static T First<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).First();
        public static T First<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).First();
        public static T First<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).First();
        public static T First<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).First(pred);
        public static T First<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).First(pred);
        public static T First<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).First(pred);
        public static T First<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).First(pred);
        public static T FirstOrDefault<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).FirstOrDefault();
        public static T FirstOrDefault<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).FirstOrDefault();
        public static T FirstOrDefault<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).FirstOrDefault();
        public static T FirstOrDefault<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).FirstOrDefault();
        public static T FirstOrDefault<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).FirstOrDefault(pred);
        public static T FirstOrDefault<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).FirstOrDefault(pred);
        public static T FirstOrDefault<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).FirstOrDefault(pred);
        public static T FirstOrDefault<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).FirstOrDefault(pred);
        public static T Last<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Last();
        public static T Last<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Last();
        public static T Last<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Last();
        public static T Last<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Last();
        public static T Last<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Last(pred);
        public static T Last<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Last(pred);
        public static T Last<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Last(pred);
        public static T Last<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Last(pred);
        public static T LastOrDefault<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).LastOrDefault();
        public static T LastOrDefault<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).LastOrDefault();
        public static T LastOrDefault<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).LastOrDefault();
        public static T LastOrDefault<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).LastOrDefault();
        public static T LastOrDefault<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).LastOrDefault(pred);
        public static T LastOrDefault<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).LastOrDefault(pred);
        public static T LastOrDefault<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).LastOrDefault(pred);
        public static T LastOrDefault<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).LastOrDefault(pred);
        public static T Max<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Max();
        public static T Max<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Max();
        public static T Max<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Max();
        public static T Max<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Max();
        public static T Max<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Max(pred);
        public static T Max<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Max(pred);
        public static T Max<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Max(pred);
        public static T Max<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Max(pred);
        public static T Min<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Min();
        public static T Min<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Min();
        public static T Min<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Min();
        public static T Min<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Min();
        public static T Min<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Min(pred);
        public static T Min<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Min(pred);
        public static T Min<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Min(pred);
        public static T Min<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Min(pred);
        public static T Average<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Average();
        public static T Average<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Average();
        public static T Average<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Average();
        public static T Average<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Average();
        public static T Average<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Average(pred);
        public static T Average<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Average(pred);
        public static T Average<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Average(pred);
        public static T Average<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Average(pred);
        public static T Sum<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Sum();
        public static T Sum<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Sum();
        public static T Sum<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Sum();
        public static T Sum<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Sum();
        public static T Sum<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Sum(pred);
        public static T Sum<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Sum(pred);
        public static T Sum<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Sum(pred);
        public static T Sum<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Sum(pred);
        public static T Multiply<T >(this IReadOnlyList<T> c )
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Multiply();
        public static T Multiply<T >(this T[] c )
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Multiply();
        public static T Multiply<T >(this HashSet<T> c )
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Multiply();
        public static T Multiply<T >(this MultiHashSetWrapper<T> c )
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Multiply();
        public static T Multiply<T >(this IReadOnlyList<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Multiply(pred);
        public static T Multiply<T >(this T[] c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Multiply(pred);
        public static T Multiply<T >(this HashSet<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Multiply(pred);
        public static T Multiply<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> pred)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Multiply(pred);
        public static RefLinqEnumerable<T, Where<T, IReadOnlyListEnumerator<T>>> Where<T >(this IReadOnlyList<T> c ,Func<T, bool> predicate)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Where(predicate);
        public static RefLinqEnumerable<T, Where<T, ArrayEnumerator<T>>> Where<T >(this T[] c ,Func<T, bool> predicate)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Where(predicate);
        public static RefLinqEnumerable<T, Where<T, HashSetEnumerator<T>>> Where<T >(this HashSet<T> c ,Func<T, bool> predicate)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Where(predicate);
        public static RefLinqEnumerable<T, Where<T, MultiHashSetWrapperEnumerator<T>>> Where<T >(this MultiHashSetWrapper<T> c ,Func<T, bool> predicate)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Where(predicate);
        public static RefLinqEnumerable<T, Skip<T, IReadOnlyListEnumerator<T>>> Skip<T >(this IReadOnlyList<T> c ,int skip)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Skip(skip);
        public static RefLinqEnumerable<T, Skip<T, ArrayEnumerator<T>>> Skip<T >(this T[] c ,int skip)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Skip(skip);
        public static RefLinqEnumerable<T, Skip<T, HashSetEnumerator<T>>> Skip<T >(this HashSet<T> c ,int skip)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Skip(skip);
        public static RefLinqEnumerable<T, Skip<T, MultiHashSetWrapperEnumerator<T>>> Skip<T >(this MultiHashSetWrapper<T> c ,int skip)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Skip(skip);
        public static RefLinqEnumerable<T, Take<T, IReadOnlyListEnumerator<T>>> Take<T >(this IReadOnlyList<T> c ,int take)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Take(take);
        public static RefLinqEnumerable<T, Take<T, ArrayEnumerator<T>>> Take<T >(this T[] c ,int take)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Take(take);
        public static RefLinqEnumerable<T, Take<T, HashSetEnumerator<T>>> Take<T >(this HashSet<T> c ,int take)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Take(take);
        public static RefLinqEnumerable<T, Take<T, MultiHashSetWrapperEnumerator<T>>> Take<T >(this MultiHashSetWrapper<T> c ,int take)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Take(take);
        public static RefLinqEnumerable<T, Append<T, IReadOnlyListEnumerator<T>>> Append<T >(this IReadOnlyList<T> c ,T toAppend)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Append(toAppend);
        public static RefLinqEnumerable<T, Append<T, ArrayEnumerator<T>>> Append<T >(this T[] c ,T toAppend)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Append(toAppend);
        public static RefLinqEnumerable<T, Append<T, HashSetEnumerator<T>>> Append<T >(this HashSet<T> c ,T toAppend)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Append(toAppend);
        public static RefLinqEnumerable<T, Append<T, MultiHashSetWrapperEnumerator<T>>> Append<T >(this MultiHashSetWrapper<T> c ,T toAppend)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Append(toAppend);
        public static RefLinqEnumerable<T, Prepend<T, IReadOnlyListEnumerator<T>>> Prepend<T >(this IReadOnlyList<T> c ,T toPrepend)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Prepend(toPrepend);
        public static RefLinqEnumerable<T, Prepend<T, ArrayEnumerator<T>>> Prepend<T >(this T[] c ,T toPrepend)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Prepend(toPrepend);
        public static RefLinqEnumerable<T, Prepend<T, HashSetEnumerator<T>>> Prepend<T >(this HashSet<T> c ,T toPrepend)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Prepend(toPrepend);
        public static RefLinqEnumerable<T, Prepend<T, MultiHashSetWrapperEnumerator<T>>> Prepend<T >(this MultiHashSetWrapper<T> c ,T toPrepend)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Prepend(toPrepend);
        public static RefLinqEnumerable<T, OrderBy<T, IReadOnlyListEnumerator<T>,TKey>> OrderBy<T ,TKey>(this IReadOnlyList<T> c ,Func<T, TKey> keySelector)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).OrderBy(keySelector);
        public static RefLinqEnumerable<T, OrderBy<T, ArrayEnumerator<T>,TKey>> OrderBy<T ,TKey>(this T[] c ,Func<T, TKey> keySelector)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).OrderBy(keySelector);
        public static RefLinqEnumerable<T, OrderBy<T, HashSetEnumerator<T>,TKey>> OrderBy<T ,TKey>(this HashSet<T> c ,Func<T, TKey> keySelector)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).OrderBy(keySelector);
        public static RefLinqEnumerable<T, OrderBy<T, MultiHashSetWrapperEnumerator<T>,TKey>> OrderBy<T ,TKey>(this MultiHashSetWrapper<T> c ,Func<T, TKey> keySelector)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).OrderBy(keySelector);
        public static RefLinqEnumerable<T, Concat<T, IReadOnlyListEnumerator<T>,TEnumerator2>> Concat<T ,TEnumerator2>(this IReadOnlyList<T> c ,RefLinqEnumerable<T, TEnumerator2> seq2)
            where TEnumerator2 : IRefEnumerator<T>
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Concat(seq2);
        public static RefLinqEnumerable<T, Concat<T, ArrayEnumerator<T>,TEnumerator2>> Concat<T ,TEnumerator2>(this T[] c ,RefLinqEnumerable<T, TEnumerator2> seq2)
            where TEnumerator2 : IRefEnumerator<T>
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Concat(seq2);
        public static RefLinqEnumerable<T, Concat<T, HashSetEnumerator<T>,TEnumerator2>> Concat<T ,TEnumerator2>(this HashSet<T> c ,RefLinqEnumerable<T, TEnumerator2> seq2)
            where TEnumerator2 : IRefEnumerator<T>
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Concat(seq2);
        public static RefLinqEnumerable<T, Concat<T, MultiHashSetWrapperEnumerator<T>,TEnumerator2>> Concat<T ,TEnumerator2>(this MultiHashSetWrapper<T> c ,RefLinqEnumerable<T, TEnumerator2> seq2)
            where TEnumerator2 : IRefEnumerator<T>
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Concat(seq2);
        public static RefLinqEnumerable<(T,T2), Zip<T, IReadOnlyListEnumerator<T>,T2,TEnumerator2>> Zip<T ,T2,TEnumerator2>(this IReadOnlyList<T> c ,RefLinqEnumerable<T2, TEnumerator2> seq2)
            where TEnumerator2 : IRefEnumerator<T2>
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Zip(seq2);
        public static RefLinqEnumerable<(T,T2), Zip<T, ArrayEnumerator<T>,T2,TEnumerator2>> Zip<T ,T2,TEnumerator2>(this T[] c ,RefLinqEnumerable<T2, TEnumerator2> seq2)
            where TEnumerator2 : IRefEnumerator<T2>
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Zip(seq2);
        public static RefLinqEnumerable<(T,T2), Zip<T, HashSetEnumerator<T>,T2,TEnumerator2>> Zip<T ,T2,TEnumerator2>(this HashSet<T> c ,RefLinqEnumerable<T2, TEnumerator2> seq2)
            where TEnumerator2 : IRefEnumerator<T2>
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Zip(seq2);
        public static RefLinqEnumerable<(T,T2), Zip<T, MultiHashSetWrapperEnumerator<T>,T2,TEnumerator2>> Zip<T ,T2,TEnumerator2>(this MultiHashSetWrapper<T> c ,RefLinqEnumerable<T2, TEnumerator2> seq2)
            where TEnumerator2 : IRefEnumerator<T2>
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Zip(seq2);
        public static RefLinqEnumerable<U, Select<T, IReadOnlyListEnumerator<T>,U>> Select<T ,U>(this IReadOnlyList<T> c ,Func<T, U> map)
            => new RefLinqEnumerable<T, IReadOnlyListEnumerator<T>>(new IReadOnlyListEnumerator<T>(c)).Select(map);
        public static RefLinqEnumerable<U, Select<T, ArrayEnumerator<T>,U>> Select<T ,U>(this T[] c ,Func<T, U> map)
            => new RefLinqEnumerable<T, ArrayEnumerator<T>>(new ArrayEnumerator<T>(c)).Select(map);
        public static RefLinqEnumerable<U, Select<T, HashSetEnumerator<T>,U>> Select<T ,U>(this HashSet<T> c ,Func<T, U> map)
            => new RefLinqEnumerable<T, HashSetEnumerator<T>>(new HashSetEnumerator<T>(c)).Select(map);
        public static RefLinqEnumerable<U, Select<T, MultiHashSetWrapperEnumerator<T>,U>> Select<T ,U>(this MultiHashSetWrapper<T> c ,Func<T, U> map)
            => new RefLinqEnumerable<T, MultiHashSetWrapperEnumerator<T>>(new MultiHashSetWrapperEnumerator<T>(c)).Select(map);
        public static RefLinqEnumerable<U, SelectMany<U, TUEnumerator, Select<T, IReadOnlyListEnumerator<T>, RefLinqEnumerable<U, TUEnumerator>>>> SelectMany<T, U, TUEnumerator>(this IReadOnlyList<T> c, Func<T, RefLinqEnumerable<U, TUEnumerator>> func)
            where TUEnumerator : IRefEnumerator<U>
            => c.Select(func).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, TUEnumerator, Select<T, ArrayEnumerator<T>, RefLinqEnumerable<U, TUEnumerator>>>> SelectMany<T, U, TUEnumerator>(this T[] c, Func<T, RefLinqEnumerable<U, TUEnumerator>> func)
            where TUEnumerator : IRefEnumerator<U>
            => c.Select(func).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, TUEnumerator, Select<T, HashSetEnumerator<T>, RefLinqEnumerable<U, TUEnumerator>>>> SelectMany<T, U, TUEnumerator>(this HashSet<T> c, Func<T, RefLinqEnumerable<U, TUEnumerator>> func)
            where TUEnumerator : IRefEnumerator<U>
            => c.Select(func).SelectMany();
        public static RefLinqEnumerable<U, SelectMany<U, TUEnumerator, Select<T, MultiHashSetWrapperEnumerator<T>, RefLinqEnumerable<U, TUEnumerator>>>> SelectMany<T, U, TUEnumerator>(this MultiHashSetWrapper<T> c, Func<T, RefLinqEnumerable<U, TUEnumerator>> func)
            where TUEnumerator : IRefEnumerator<U>
            => c.Select(func).SelectMany();
    }
}
