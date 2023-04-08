// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class SumTest
{
    [Fact]
    public void ListWithIntData()
    {
        Assert.Equal(6, new [] { 1, 2, 3 }.Sum());
    }

    [Fact]
    public void ListWithDoubleData()
    {
        Assert.Equal(7d, new[] { 1.25, 2.5, 3.25 }.Sum());
    }

    [Fact]
    public void EmptyList()
    {
        Assert.Equal(0, new int[] { }.Sum());
    }
}