using System.Collections.Generic;

namespace System.Linq.Struct
{
    public class MultiHashSetWrapper<T>
    {
        public HashSet<T> Set;

        public HashSet<T>.Enumerator GetEnumerator() => Set.GetEnumerator();
    }
}