// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class FirstTest
{
    [Fact]
    public void ListContainsValue()
    {
        Assert.Equal(2, new[] { 2, 3, 4 }.First());
    }

    [Fact]
    public void ListDoesNotContainValue()
    {
        Assert.Throws<System.InvalidOperationException>(() => new int[] { }.First());
    }
}