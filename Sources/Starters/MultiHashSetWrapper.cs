using System.Collections.Generic;

namespace System.Linq.Struct
{
    public class MultiHashSetWrapper<T>
    {
        public HashSet<T> Data;

        public HashSet<T>.Enumerator GetEnumerator() => Data.GetEnumerator();
    }
}