using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Struct
{
    public class MultiListWrapper<T> : IReadOnlyList<T>
    {
        public IReadOnlyList<T> Data;

        public T this[int index] => this.Data[index];

        public int Count => this.Data.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }
    }
}