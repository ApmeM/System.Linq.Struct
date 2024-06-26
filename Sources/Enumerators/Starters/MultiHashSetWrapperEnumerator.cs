﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Struct
{
    public struct MultiHashSetWrapperEnumerator<T> : IRefEnumerator<T>
    {
        private MultiHashSetWrapper<T> set;
        private HashSet<T>.Enumerator ie;
        private bool initialized;

        public MultiHashSetWrapperEnumerator(MultiHashSetWrapper<T> wrapper)
        {
            this.set = wrapper;
            this.Current = default;
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
            this.Current = this.ie.Current;
            if (!t)
                this.ie.Dispose();
            return t;
        }

        public T Current { get; private set; }
    }
}