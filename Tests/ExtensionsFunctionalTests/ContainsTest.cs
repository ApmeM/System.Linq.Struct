// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class ContainsTest
{
    [Fact]
    public void ListContainsValue()
    {
        Assert.True(new[] { 1, 2, 3, 4 }.Contains(2));
    }

    [Fact]
    public void ListDoesNotContainValue()
    {
        Assert.False(new[] { 1, 2, 3, 4 }.Contains(5));
    }

    [Fact]
    public void ListEmpty()
    {
        Assert.False(new int[] { }.Contains(5));
    }
}