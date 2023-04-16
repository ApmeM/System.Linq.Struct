// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class RepeatTest
{
    [Fact]
    public void RepeatZeroTimesToEmptyList()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Repeat(0), new int[] { });
    }

    [Fact]
    public void RepeatEmptyListTwice()
    {
        TestUtils.EqualSequences(new int[] { }.Repeat(2), new int[] { });
    }

    [Fact]
    public void RepeatNormlListThreeTimes()
    {
        TestUtils.EqualSequences(new int[] { 1, 2, 3 }.Repeat(3), new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 });
    }

    [Fact]
    public void RepeatNormalListOnec()
    {
        TestUtils.EqualSequences(new int[] { 1, 2, 3 }.Repeat(1), new[] { 1, 2, 3 });
    }
}