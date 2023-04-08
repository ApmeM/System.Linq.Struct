// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System;

namespace Tests.ExtensionsFunctionalTests;

public class SingleTest
{
    [Fact]
    public void ListContainsSingleValue()
    {
        Assert.Equal(2, new[] { 2 }.Single());
    }

    [Fact]
    public void EmptyList()
    {
        var seq = new int[] { };
        Assert.Throws<InvalidOperationException>(() => seq.Single());
    }

    [Fact]
    public void ListContainsMultipleValues()
    {
        Assert.Throws<InvalidOperationException>(() => new int[] { 1, 2 }.Single());
    }
}