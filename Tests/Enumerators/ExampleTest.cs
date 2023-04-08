// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class ExampleTest
{
    [Fact]
    public void MultipleChainedMethods()
    {
        var arr = new[] { 1, 2, 3, 4 };

        var localVar = 5;

        var seq =
            arr
            .Select(c => c + 5)
            .Where(c => c % 2 == 0)
            .Select(c => c - 6.0 / localVar)
            .Append(3)
            .Append(5)
            .Prepend(3)
            .OrderBy(a => a)
            .Skip(2)
            .Take(10)
            .Concat(arr.Select(c => c / 1d));
        Assert.Equal(33.4, seq.Sum() + seq.Max());
    }
}