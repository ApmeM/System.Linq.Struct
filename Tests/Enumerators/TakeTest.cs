// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class TakeTest
{
    [Fact]
    public void TakeEnoughData()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Take(2), new[] { 1, 2 });
    }

    [Fact]
    public void TakeAllData()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Take(3), new[] { 1, 2, 3 });
    }

    [Fact]
    public void TakeMoreDataThenExists()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Take(6), new[] { 1, 2, 3 });
    }

    [Fact]
    public void TakeZeroItems()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Take(0), new int[] { });
    }
}
