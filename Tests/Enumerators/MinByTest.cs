// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System;

namespace Tests.ExtensionsFunctionalTests;

public class MinByTest
{
    [Fact]
    public void ListContainsIntValues()
    {
        Assert.Equal((1, "f"), new[] { (5, "a"), (7, "b"), (3, "c"), (4, "d"), (5, "e"), (1, "f"), (1, "g") }.MinBy(c => c.Item1));
    }

    [Fact]
    public void ListContainsDoubleValues()
    {
        Assert.Equal(":d", new[] { (2.4, "ohNO!"), (2.0, "hahah!"), (-3.3, ":d") }.MinBy(a => a.Item1).Item2);
    }

    [Fact]
    public void EmptyList()
    {
        Assert.Throws<InvalidOperationException>(() => new float[] { }.MinBy(c => c));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal("aaaa", new[] { (1.0f, "aaaa") }.MinBy(c => c.Item1).Item2);
    }
}