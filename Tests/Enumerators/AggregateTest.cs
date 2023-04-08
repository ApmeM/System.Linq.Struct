// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class AggregateTest
{
    [Fact]
    public void WithAccumulator()
    {
        Assert.Equal("123", new [] { 1, 2, 3 }.Aggregate("", (a, b) => a + b));
    }

    [Fact]
    public void WithoutAccumulator()
    {
        Assert.Equal(6, new[] { 1, 2, 3 }.Aggregate((a, b) => a + b));
    }
}