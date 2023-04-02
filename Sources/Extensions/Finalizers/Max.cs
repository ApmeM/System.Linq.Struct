// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace System.Linq.Struct
{

    public static partial class ActiveLinqExtensions
    {
        public static int Max<TEnumerator>(this RefLinqEnumerable<int, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<int>
        {
            bool haveData = false;
            var max = int.MinValue;
            foreach (var v in seq)
            {
                haveData = true;
                if (max < v)
                {
                    max = v;
                }
            }
            
            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
            
            return max;
        }

        public static float Max<TEnumerator>(this RefLinqEnumerable<float, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<float>
        {
            bool haveData = false;
            var max = float.MinValue;
            foreach (var v in seq)
            {
                haveData = true;
                if (max < v)
                {
                    max = v;
                }
            }
            
            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return max;
        }

        public static double Max<TEnumerator>(this RefLinqEnumerable<double, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<double>
        {
            bool haveData = false;
            var max = double.MinValue;
            foreach (var v in seq)
            {
                haveData = true;
                if (max < v)
                {
                    max = v;
                }
            }
            
            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return max;
        }
    }
}