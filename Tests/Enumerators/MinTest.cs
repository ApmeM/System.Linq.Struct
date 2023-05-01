// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System;

namespace Tests.ExtensionsFunctionalTests;

public class MinTest
{
    [Fact]
    public void ListWithData()
    {
        Assert.Equal(-1, new[] { 1, 7, 3, 4, 5, -1, -1 }.Min());
    }

    [Fact]
    public void EmptyList()
    {
        Assert.Throws<InvalidOperationException>(() => new float[] { }.Min());
    }

    [Fact]
    public void SingleElementList()
    {
        Assert.Equal(1.0f, new float[] { 1.0f }.Min());
    }
}