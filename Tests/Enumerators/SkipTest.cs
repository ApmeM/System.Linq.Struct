// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class SkipTest
{
    [Fact]
    public void ListContainsEnoughData()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4 }.Skip(2), new[] { 3, 4 });
    }

    [Fact]
    public void SkipZeroValues()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4 }.Skip(0), new[] { 1, 2, 3, 4 });
    }

    [Fact]
    public void SkipAllValues()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4 }.Skip(4), new int[] { });
    }

    [Fact]
    public void SkipMoreValuesThenExists()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4 }.Skip(6), new int[] { });
    }
}