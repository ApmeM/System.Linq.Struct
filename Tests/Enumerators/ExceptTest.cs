// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class ExceptTest
{
    [Fact]
    public void BothListsHaveData()
    {
        TestUtils.EqualSequences(new [] { 1, 2, 3 }.Except(new [] { 3, 4, 5 }), new [] { 1, 2 });
    }

    [Fact]
    public void OriginalListEmpty()
    {
        TestUtils.EqualSequences(new int[] { }.Except(new[] { 4, 5 }), new int[] { });
    }

    [Fact]
    public void SecondListEmpty()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Except(new int[] { }), new[] { 1, 2, 3 });
    }

    [Fact]
    public void BothListEmpty()
    {
        TestUtils.EqualSequences(new int[] { }.Except(new int[] { }), new int[] { });
    }
}