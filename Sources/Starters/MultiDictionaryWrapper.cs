using System.Collections.Generic;

namespace System.Linq.Struct
{
    public class MultiDictionaryWrapper<T1, T2>
    {
        public Dictionary<T1, T2> Data;

        public Dictionary<T1, T2>.Enumerator GetEnumerator() => Data.GetEnumerator();
    }
}