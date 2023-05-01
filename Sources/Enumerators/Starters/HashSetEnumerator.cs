using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct HashSetEnumerator<T> : IRefEnumerator<T>
    {
        private T curr;
        private HashSet<T>.Enumerator ie;

        public HashSetEnumerator(HashSet<T> set)
        {
            this.ie = set.GetEnumerator();
            this.curr = default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            bool t = this.ie.MoveNext();
            this.curr = this.ie.Current;
            if (!t)
                this.ie.Dispose();
            return t;
        }

        public T Current => curr;
    }
}