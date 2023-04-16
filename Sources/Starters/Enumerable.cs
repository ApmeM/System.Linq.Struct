using System.Collections.Generic;

namespace System.Linq.Struct
{
    public static class Enumerable
    {
        public static RefLinqEnumerable<int, RangeEnumerator> Range(int start, int count)
            => new RefLinqEnumerable<int, RangeEnumerator>(new RangeEnumerator(start, count));
        public static RefLinqEnumerable<T, RepeatEnumerator<T>> Repeat<T>(T item, int count)
            => new RefLinqEnumerable<T, RepeatEnumerator<T>>(new RepeatEnumerator<T>(item, count));
    }
}