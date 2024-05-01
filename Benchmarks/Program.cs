using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CodegenAnalysis;
using CodegenAnalysis.Benchmarks;
using Iced.Intel;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
public class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<Program>();
    }

    [Params(10000)]
    public int ArrayLength { get; set; }
    private int[] arr = default!;

    [GlobalSetup]
    public void Setup()
    {
        arr = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Range(1, ArrayLength));
    }

    [Benchmark]
    public void Struct()
    {
        if (!arr.Any())
        {
            throw new System.Exception();
        }
    }

    [Benchmark]
    public void Classic()
    {
        if (!((IEnumerable<int>)arr).Any())
        {
            throw new System.Exception();
        }
    }
}