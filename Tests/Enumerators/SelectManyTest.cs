// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class SelectManyTest
{
    public static RefLinqEnumerable<int, RangeEnumerator> Range(int start, int count)
        => new RefLinqEnumerable<int, RangeEnumerator>(new RangeEnumerator(start, count));

    [Fact]
    public void EmptyList()
    {
        TestUtils.EqualSequences(new int[] { }.SelectMany(c => Range(1, (int)c)), new int[] { });
    }

    [Fact]
    public void WithCondition()
    {
        TestUtils.EqualSequences(new[] { 1d, 2d, 3d }.SelectMany(c => Range(1, (int)c)), new[] { 1, 1, 2, 1, 2, 3 });
    }

    [Fact]
    public void UsingLocalVariable()
    {
        var local = 1;
        TestUtils.EqualSequences(new[] { 1d, 2d, 3d }.SelectMany(c => Range(1, (int)c + local)), new[] { 1, 2, 1, 2, 3, 1, 2, 3, 4 });
    }

    [Fact]
    public void OnlyEmptyEnumerables()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4, 5 }.SelectMany(i => Range(0, -1)), new int[] { });
    }

    [Fact]
    public void SublistIsArray()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4, 5 }.SelectMany(i => new int[] { 1 }), new int[] { 1, 1, 1, 1, 1 });
    }
}