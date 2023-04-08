using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Struct
{
    public class MultiListWrapper<T> : IReadOnlyList<T>
    {
        public IReadOnlyList<T> Data;

        public T this[int index] => Data[index];

        public int Count => Data.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Data.GetEnumerator();
        }
    }
}