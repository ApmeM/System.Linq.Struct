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
            this.set = wrapper;
            this.curr = default;
            this.ie = default;
            this.initialized = false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!this.initialized)
            {
                this.ie = this.set.GetEnumerator();
                this.initialized = true;
            }

            bool t = this.ie.MoveNext();
            this.curr = this.ie.Current;
            if (!t)
                this.ie.Dispose();
            return t;
        }

        public KeyValuePair<T1, T2> Current => curr;
    }
}