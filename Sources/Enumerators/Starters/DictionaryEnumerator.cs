using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct DictionaryEnumerator<T, T2> : IRefEnumerator<KeyValuePair<T, T2>>
    {
        private KeyValuePair<T, T2> curr;
        private Dictionary<T, T2>.Enumerator ie;

        public DictionaryEnumerator(Dictionary<T, T2> set)
        {
            ie = set.GetEnumerator();
            curr = default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            bool t = ie.MoveNext();
            curr = ie.Current;
            if (!t)
                ie.Dispose();
            return t;
        }

        public KeyValuePair<T, T2> Current => curr;
    }
}