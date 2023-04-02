// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System;
using HonkPerf.NET.RefLinq.Enumerators;

namespace HonkPerf.NET.RefLinq
{
    public static partial class ActiveLinqExtensions
    {
        public static int Min<TEnumerator>(this RefLinqEnumerable<int, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<int>
        {
            bool haveData = false;
            var min = int.MaxValue;
            foreach (var v in seq)
            {
                haveData = true;
                if (min > v)
                {
                    min = v;
                }
            }
            
            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return min;
        }
        public static float Min<TEnumerator>(this RefLinqEnumerable<float, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<float>
        {
            bool haveData = false;
            var min = float.MaxValue;
            foreach (var v in seq)
            {
                haveData = true;
                if (min > v)
                {
                    min = v;
                }
            }
            
            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return min;
        }
        public static double Min<TEnumerator>(this RefLinqEnumerable<double, TEnumerator> seq)
            where TEnumerator : IRefEnumerator<double>
        {
            bool haveData = false;
            var min = double.MaxValue;
            foreach (var v in seq)
            {
                haveData = true;
                if (min > v)
                {
                    min = v;
                }
            }

            if (!haveData)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            return min;
        }
    }
}