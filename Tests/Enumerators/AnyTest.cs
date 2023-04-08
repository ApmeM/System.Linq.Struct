// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class AnyTest
{
    [Fact]
    public void ListContainsValue()
    {
        Assert.True(new[] { 1, 2, 3, 4 }.Any(c => c > 3));
    }

    [Fact]
    public void ListDoesNotContainValue()
    {
        Assert.False(new[] { 1, 2, 3, 4 }.Any(c => c < 1));
    }

    [Fact]
    public void EmptyList()
    {
        Assert.False(new int[] { }.Any(c => c == 5));
    }
}