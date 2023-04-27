// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System.Collections.Generic;

namespace Tests.ExtensionsFunctionalTests;

public class ToDictionaryTest
{
    [Fact]
    public void ListContainsValue()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4 }.Select(a => new KeyValuePair<int, int>(a, a)), new[] { 1, 2, 3, 4 }.ToDictionary(a => a));
    }

    [Fact]
    public void WithValueSelector()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4 }.Select(a => new KeyValuePair<int, int>(a, a + 1)), new[] { 1, 2, 3, 4 }.ToDictionary(a => a, a => a + 1));
    }
    [Fact]
    public void WithTempObject()
    {
        var dict = new Dictionary<int, int>();
        new[] { 1, 2, 3, 4 }.ToDictionary(a => a, dict);
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4 }.Select(a => new KeyValuePair<int, int>(a, a)), dict);
    }

    [Fact]
    public void WithValueSelectorAndDict()
    {
        var dict = new Dictionary<int, int>();
        new[] { 1, 2, 3, 4 }.ToDictionary(a => a, a => a + 1, dict);
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4 }.Select(a => new KeyValuePair<int, int>(a, a + 1)), dict);
    }
}