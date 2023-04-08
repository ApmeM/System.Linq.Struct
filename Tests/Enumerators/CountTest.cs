// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class CountTest
{
    [Fact]
    public void TotalAmountOfItems()
    {
        Assert.Equal(4, new[] { 1, 2, 3, 4 }.Count());
    }

    [Fact]
    public void WithCondition()
    {
        Assert.Equal(2, new[] { 1, 2, 3, 4 }.Count(c => c is >= 2 and <= 3));
    }

    [Fact]
    public void ListEmpty()
    {
        Assert.Equal(0, new int[] { }.Count());
    }
}