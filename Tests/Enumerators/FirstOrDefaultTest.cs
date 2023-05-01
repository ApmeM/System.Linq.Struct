// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class FirstOrDefaultTest
{
    [Fact]
    public void ListContainsValue()
    {
        Assert.Equal(2, new[] { 2, 3, 4 }.FirstOrDefault());
    }

    [Fact]
    public void ListContainsValueWithCondition()
    {
        Assert.Equal(3, new[] { 2, 3, 4 }.FirstOrDefault(c => c > 2));
    }

    [Fact]
    public void EmptyList()
    {
        Assert.Equal(0, new int[] { }.FirstOrDefault());
    }

    [Fact]
    public void ListDoesNotContainValue()
    {
        Assert.Equal(0, new[] { 1 }.FirstOrDefault(c => c > 1));
    }
}