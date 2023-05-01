using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct MultiDictionaryWrapperEnumerator<T1, T2> : IRefEnumerator<KeyValuePair<T1, T2>>
    {
        private KeyValuePair<T1, T2> curr;
        private MultiDictionaryWrapper<T1, T2> set;
        private Dictionary<T1, T2>.Enumerator ie;
        private bool initialized;

        public MultiDictionaryWrapperEnumerator(MultiDictionaryWrapper<T1, T2> wrapper)
        {
            set = wrapper;
            curr = default;
            ie = default;
            initialized = false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!initialized)
            {
                ie = set.GetEnumerator();
                initialized = true;
            }

            bool t = ie.MoveNext();
            curr = ie.Current;
            if (!t)
                ie.Dispose();
            return t;
        }

        public KeyValuePair<T1, T2> Current => curr;
    }
}