// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using BenchmarkDotNet.Attributes;
using System.Runtime.CompilerServices;
using NoAlloq;
using JM.LinqFaster;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Linq.Struct;
using System.Linq;
using System.Collections.Generic;

[MemoryDiagnoser]
public class DifferentLengths
{

    [Params(10000)]
    public int ArrayLength { get; set; }
    private int[] arr = default!;
    private int[] arr2 = default!;

    private static MultiListWrapper<int> data = new MultiListWrapper<int>();
    private System.Linq.Struct.RefLinqEnumerable<int, System.Linq.Struct.Prepend<int, System.Linq.Struct.Take<int, System.Linq.Struct.OrderBy<int, System.Linq.Struct.Skip<int, System.Linq.Struct.Append<int, System.Linq.Struct.Where<int, System.Linq.Struct.Select<int, System.Linq.Struct.IReadOnlyListEnumerator<int>, int>>>>, int>>>> cachedQuery = data
                .Select(c => c + 5)
                .Where(c => c % 2 == 0)
                .Append(5)
                .Skip(10)
                .OrderBy(c => c)
                .Take(20)
                .Prepend(42);


    [GlobalSetup]
    public void Setup()
    {
        arr = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Range(1, ArrayLength));
        arr2 = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Range(1, 100));
    }

    [Benchmark]
    public double StructWithoutOrderBy()
    {
        var res = 0.0;

        var seq = arr
            .Select(c => c + 5)
            .Where(c => c % 2 == 0)
            .Append(5)
            .Skip(10)
            .Take(20)
            .Prepend(42);
        foreach (var a in seq)
            res += a;
        return res;
    }

    [Benchmark]
    public double ClassicWithoutOrderBy()
    {
        var res = 0.0;
        var seq = ((IEnumerable<int>)arr)
            .Select(c => c + 5)
            .Where(c => c % 2 == 0)
            .Append(5)
            .Skip(10)
            .Take(20)
            .Prepend(42);
        foreach (var a in seq)
            res += a;
        return res;
    }


    [Benchmark]
    public double StructWithOrderBy()
    {
        var res = 0.0;

        var seq = arr
            .Select(c => c + 5)
            .Where(c => c % 2 == 0)
            .Append(5)
            .Skip(10)
            .OrderBy(c => c)
            .Take(20)
            .Prepend(42);
        foreach (var a in seq)
            res += a;
        return res;
    }

    [Benchmark]
    public double ClassicWithOrderBy()
    {
        var res = 0.0;
        var seq = ((IEnumerable<int>)arr)
            .Select(c => c + 5)
            .Where(c => c % 2 == 0)
            .Append(5)
            .Skip(10)
            .OrderBy(c => c)
            .Take(20)
            .Prepend(42);
        foreach (var a in seq)
            res += a;
        return res;
    }

    [Benchmark]
    public double StructCachedQuery()
    {
        var res = 0.0;
        data.Data = arr;
        foreach (var a in cachedQuery)
            res += a;
        return res;
    }

}

