// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class SelectManyTest
{
    [Fact]
    public void WithoutCondition()
    {
        TestUtils.EqualSequences(new [] { 1d, 2d, 3d }.Select(c => LazyLinqExtensions.Range(1, (int)c)).SelectMany(), new [] { 1, 1, 2, 1, 2, 3 });
    }
    
    [Fact]
    public void EmptyList()
    {
        TestUtils.EqualSequences(new int[] { }.SelectMany(c => LazyLinqExtensions.Range(1, (int)c)), new int[] { });
    }

    [Fact]
    public void WithCondition()
    {
        TestUtils.EqualSequences(new[] { 1d, 2d, 3d }.SelectMany(c => LazyLinqExtensions.Range(1, (int)c)), new[] { 1, 1, 2, 1, 2, 3 });
    }

    [Fact]
    public void UsingLocalVariable()
    {
        var local = 1;
        TestUtils.EqualSequences(new[] { 1d, 2d, 3d }.SelectMany(c => LazyLinqExtensions.Range(1, (int)c + local)), new[] { 1, 2, 1, 2, 3, 1, 2, 3, 4 });
    }

    [Fact]
    public void OnlyEmptyEnumerables()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4, 5 }.Select(i => LazyLinqExtensions.Range(0, -1)).SelectMany(), new int[] { });
    }
}