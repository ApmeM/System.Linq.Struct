// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class ZipTest
{
    [Fact]
    public void ListsOfEqualSizes()
    {
        var a = new [] { 1, 2, 3 };
        var b = new [] { "aa", "aaa", "b" };
        TestUtils.EqualSequences(a.Zip(b), new [] { (1, "aa"), (2, "aaa"), (3, "b") });
    }

    [Fact]
    public void ListsOfDifferentSizesFirstLonger()
    {
        var a = new[] { 1, 2, 3 };
        var b = new[] { "aa", "aaa" };
        Assert.Throws<System.InvalidOperationException>(() => a.Zip(b).Count());
    }

    [Fact]
    public void ListsOfDifferentSizesSecondLonger()
    {
        var a = new[] { 1, 2 };
        var b = new[] { "aa", "aaa", "b" };
        Assert.Throws<System.InvalidOperationException>(() => a.Zip(b).Count());
    }

    [Fact]
    public void EmptyLists()
    {
        var a = new int[] { };
        var b = new string[] { };
        TestUtils.EqualSequences(a.Zip(b), new (int, string)[0]);
    }
}