// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class MultiplyTest
{
    [Fact]
    public void ListWithIntData()
    {
        Assert.Equal(6, new [] { 1, 2, 3 }.Multiply());
    }

    [Fact]
    public void ListWithDoubleData()
    {
        Assert.Equal(14d, new[] { 4, 0.5, 7 }.Multiply());
    }

    [Fact]
    public void EmptyList()
    {
        Assert.Equal(0, new int[] { }.Multiply());
    }
}