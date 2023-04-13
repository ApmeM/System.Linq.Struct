// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System;
using System.Collections.Generic;

namespace Tests.Starters;

public class MultiUsageWrappers
{

    [Fact]
    public void MultiListWrapper()
    {
        var data = new MultiListWrapper<ValueTuple<int, string>>();
        var query = data.OrderBy(a => a.Item1);
        var l1 = new (int, string)[] { (3, "a"), (1, "b"), (2, "c") };
        var l2 = new List<(int, string)> { (4, "a"), (5, "b"), (6, "c") };
        data.Data = l1;
        TestUtils.EqualSequences(query, new[] { (1, "b"), (2, "c"), (3, "a") });
        data.Data = l2;
        TestUtils.EqualSequences(query, new[] { (4, "a"), (5, "b"), (6, "c") });
    }

    [Fact]
    public void MultiHashSetWrapper()
    {
        var data = new MultiHashSetWrapper<ValueTuple<int, string>>();
        var query = data.OrderBy(a => a.Item1);
        var l1 = new HashSet<(int, string)> { (3, "a"), (1, "b"), (2, "c") };
        var l2 = new HashSet<(int, string)> { (4, "a"), (5, "b"), (6, "c") };
        data.Data = l1;
        TestUtils.EqualSequences(query, new[] { (1, "b"), (2, "c"), (3, "a") });
        data.Data = l2;
        TestUtils.EqualSequences(query, new[] { (4, "a"), (5, "b"), (6, "c") });
    }

    [Fact]
    public void Array()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Select(c => c * 2), new[] { 2, 4, 6 });
    }

    [Fact]
    public void List()
    {
        TestUtils.EqualSequences(new List<int> { 1, 2, 3 }.Select(c => c * 2), new[] { 2, 4, 6 });
    }

    [Fact]
    public void HashSet()
    {
        TestUtils.EqualSequences(new HashSet<int> { 1, 2, 3 }.Select(c => c * 2), new[] { 2, 4, 6 });
    }

    [Fact]
    public void Dictionary()
    {
        TestUtils.EqualSequences(new Dictionary<int, int> { { 1, 1 }, { 2, 2 }, {3, 3} }.Select(c => c.Value * 2), new[] { 2, 4, 6 });
    }
}