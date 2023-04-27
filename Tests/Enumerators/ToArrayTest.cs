// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;

namespace Tests.ExtensionsFunctionalTests;

public class ToArrayTest
{
    [Fact]
    public void ListContainsValue()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4}.Select(a => a), new[] { 1, 2, 3, 4 }.ToArray());
    }
    [Fact]
    public void WithTempObject()
    {
        var list = new List<int>();
        var arr = new[] { 1, 2, 3, 4 }.ToArray(list);
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4}.Select(a => a), arr);
    }
}