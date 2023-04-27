// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class DistinctTest
{
    [Fact]
    public void ListWithData()
    {
        TestUtils.EqualSequences(new[] { 3, 1, 3, 2 }.Distinct(), new[] { 3, 1, 2 });
    }

    [Fact]
    public void EmptyList()
    {
        TestUtils.EqualSequences(new int[] { }.Distinct(), new int[] { });
    }

    [Fact]
    public void WithKeySelector()
    {
        TestUtils.EqualSequences(new[] { (3, "a"), (1, "b"), (3, "d"), (2, "c") }.Distinct(), new[] { (3, "a"), (1, "b"), (3, "d"), (2, "c") });
    }
}
