// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System;

namespace Tests.ExtensionsFunctionalTests;

public class SingleOrDefaultTest
{
    [Fact]
    public void ListContainsValue()
    {
        Assert.Equal(2, new[] { 2 }.SingleOrDefault());
    }

    [Fact]
    public void EmptyList()
    {
        Assert.Equal(0, new int[] { }.SingleOrDefault());
    }

    [Fact]
    public void ListContainsMultipleValues()
    {
        Assert.Equal(0, new int[] { 1, 2 }.SingleOrDefault());
    }

    [Fact]
    public void ListContainsSingleValueByCondition()
    {
        Assert.Equal(1, new int[] { 1, 2 }.SingleOrDefault(a => a == 1));
    }
}