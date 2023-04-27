// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;

namespace Tests.ExtensionsFunctionalTests;

public class ToHashSetTest
{
    [Fact]
    public void ListContainsValue()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3}.Select(a => a), new[] { 1, 2, 3, 1 }.ToHashSet());
    }
    [Fact]
    public void WithTempObject()
    {
        var set = new HashSet<int>();
        new[] { 1, 2, 3, 4 }.ToHashSet(set);
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4}.Select(a => a), set);
    }

}