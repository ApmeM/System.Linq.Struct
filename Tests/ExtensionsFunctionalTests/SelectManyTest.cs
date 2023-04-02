﻿// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class SelectManyTest
{
    [Fact]
    public void Test1()
    {
        var a = 
            new [] { 1d, 2d, 3d }
            .Select(c => TestUtils.Range(1, (int)c).ToRefLinq())
            .SelectMany();
        TestUtils.EqualSequences(a, new [] { 1, 1, 2, 1, 2, 3 });
    }

    [Fact]
    public void Test2()
    {
        var a =
            new[] { 1d, 2d, 3d }
            .SelectMany(c => TestUtils.Range(1, (int)c).ToRefLinq());
        TestUtils.EqualSequences(a, new[] { 1, 1, 2, 1, 2, 3 });
    }

    [Fact]
    public void Test3()
    {
        var local = 1;
        var a =
            new[] { 1d, 2d, 3d }
            .SelectMany(c => TestUtils.Range(1, (int)c + local).ToRefLinq());
        TestUtils.EqualSequences(a, new[] { 1, 2, 1, 2, 3, 1, 2, 3, 4 });
    }

    [Fact]
    public void OnlyEmptyEnumerables()
    {
        var a =
            new[] { 1, 2, 3, 4, 5 }
            .Select(i => System.Array.Empty<int>().ToRefLinq())
            .SelectMany();
        TestUtils.EqualSequences(a, new int[] { });
    }

    [Fact]
    public void WithEmptyEnumerables()
    {
        var a =
            new[] { 1, 2, 3, 4, 5 }
            .Select(i => (i % 2 == 0 ? System.Array.Empty<int>() : new[] { i, i * 2, i * 3 }).ToRefLinq())
            .SelectMany();
        TestUtils.EqualSequences(a, new[] { 1, 2, 3, 3, 6, 9, 5, 10, 15 });
    }
}