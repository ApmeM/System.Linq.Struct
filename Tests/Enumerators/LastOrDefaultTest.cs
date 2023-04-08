// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class LastOrDefaultTest
{
    [Fact]
    public void ListContainsValue()
    {
        Assert.Equal(4, new[] { 2, 3, 4 }.LastOrDefault());
    }

    [Fact]
    public void EmptyList()
    {
        Assert.Equal(0, new int[] { }.LastOrDefault());
    }
}