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
public class RepeatTest
{
    [Params(10000)]
    public int ArrayLength { get; set; }
    private int[] arr = default!;

    [GlobalSetup]
    public void Setup()
    {
        arr = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Range(1, ArrayLength));
    }

    [Benchmark]
    public double StructInList()
    {
        var res = 0.0;

        var seq = arr.Repeat(2);
        foreach (var a in seq)
            res += a;
        return res;
    }

    [Benchmark]
    public double StructInStatic()
    {
        var res = 0.0;

        var seq = System.Linq.Struct.Enumerable.Repeat(arr, 2).SelectMany(a => a);
        foreach (var a in seq)
            res += a;
        return res;
    }

    [Benchmark]
    public double Classic()
    {
        var res = 0.0;
        var seq = System.Linq.Enumerable.Repeat(arr, 2).SelectMany(a => a);
        foreach (var a in seq)
            res += a;
        return res;
    }
}