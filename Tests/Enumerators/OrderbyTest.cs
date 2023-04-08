// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class OrderbyTest
{
    [Fact]
    public void ListWithData()
    {
        TestUtils.EqualSequences(new[] { 3, 1, 2 }.OrderBy(a => a), new[] { 1, 2, 3 });
    }

    [Fact]
    public void EmptyList()
    {
        TestUtils.EqualSequences(new int[] { }.OrderBy(a => a), new int[] { });
    }

    [Fact]
    public void WithKeySelector()
    {
        TestUtils.EqualSequences(new[] { (3, "a"), (1, "b"), (2, "c") }.OrderBy(a => a.Item1), new[] { (1, "b"), (2, "c"), (3, "a") });
    }
}
