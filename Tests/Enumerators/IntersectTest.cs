// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class IntersectTest
{
    [Fact]
    public void BothListsHaveData()
    {
        TestUtils.EqualSequences(new [] { 1, 2, 3 }.Intersect(new [] { 3, 4, 5 }), new [] { 3 });
    }

    [Fact]
    public void OriginalListEmpty()
    {
        TestUtils.EqualSequences(new int[] { }.Intersect(new[] { 4, 5 }), new int[] { });
    }

    [Fact]
    public void SecondListEmpty()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Intersect(new int[] { }), new int[] { });
    }

    [Fact]
    public void BothListEmpty()
    {
        TestUtils.EqualSequences(new int[] { }.Intersect(new int[] { }), new int[] { });
    }
}