using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct HashSetEnumerator<T> : IRefEnumerator<T>
    {
        private HashSet<T>.Enumerator ie;

        public HashSetEnumerator(HashSet<T> set)
        {
            this.ie = set.GetEnumerator();
            this.Current = default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            bool t = this.ie.MoveNext();
            this.Current = this.ie.Current;
            if (!t)
                this.ie.Dispose();
            return t;
        }

        public T Current { get; private set; }
    }
}