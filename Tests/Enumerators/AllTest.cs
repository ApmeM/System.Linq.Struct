// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class AllTest
{
    [Fact]
    public void ListContainsValue()
    {
        Assert.True(new[] { 1, 2, 3, 4 }.All(c => c < 5));
    }

    [Fact]
    public void ListDoesNotContainValue()
    {
        Assert.False(new[] { 1, 2, 3, 4 }.All(c => c < 3));
    }

    [Fact]
    public void EmptyList()
    {
        Assert.True(new int[] { }.All(c => c < 5));
    }
}