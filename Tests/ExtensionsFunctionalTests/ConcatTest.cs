// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class ConcatTest
{
    [Fact]
    public void BothListsHaveData()
    {
        TestUtils.EqualSequences(new [] { 1, 2, 3 }.Concat(new [] { 4, 5 }.ToRefLinq()), new [] { 1, 2, 3, 4, 5 });
    }

    [Fact]
    public void OriginalListEmpty()
    {
        TestUtils.EqualSequences(new int[] { }.Concat(new[] { 4, 5 }.ToRefLinq()), new[] { 4, 5 });
    }

    [Fact]
    public void SecondListEmpty()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Concat(new int[] { }.ToRefLinq()), new[] { 1, 2, 3 });
    }

    [Fact]
    public void BothListEmpty()
    {
        TestUtils.EqualSequences(new int[] { }.Concat(new int[] { }.ToRefLinq()), new int[] { });
    }
}