// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;

namespace Tests.ExtensionsFunctionalTests;

public class IntersectTest
{
    [Fact]
    public void BothListsHaveData()
    {
        TestUtils.EqualSequences(new [] { 1, 2, 3 }.Intersect(new [] { 3, 4, 5 }), new [] { 3 });
    }

    [Fact]
    public void OriginalListEmpty()
    {
        TestUtils.EqualSequences(new int[] { }.Intersect(new[] { 4, 5 }), new int[] { });
    }

    [Fact]
    public void SecondListEmpty()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Intersect(new int[] { }), new int[] { });
    }

    [Fact]
    public void BothListEmpty()
    {
        TestUtils.EqualSequences(new int[] { }.Intersect(new int[] { }), new int[] { });
    }

    [Fact]
    public void ChangeListBetweenCalls()
    {
        var l1 = new List<int> { 1, 2, 3 };
        var l2 = new List<int> { 3, 4, 5 };
        var query = l1.Intersect(l2);
        TestUtils.EqualSequences(query, new int[] { 3 });
        l1.Add(3);
        l2.Add(2);
        TestUtils.EqualSequences(query, new int[] { 2, 3, 3 });
    }

}