// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class SelectTest
{
    [Fact]
    public void ListWithData()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Select(c => c * 2), new[] { 2, 4, 6 });
    }

    [Fact]
    public void EmptyList()
    {
        TestUtils.EqualSequences(new int[] { }.Select(c => c * 2), new int[] { });
    }

    [Fact]
    public void UsingLocalVariable()
    {
        var local = 5;
        TestUtils.EqualSequences(new int[] { 1, 2, 3 }.Select(c => c * local), new int[] { 5, 10, 15 });
    }
}