// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class ReverseTest
{
    [Fact]
    public void ListWithData()
    {
        TestUtils.EqualSequences(new[] { 3, 1, 2 }.Reverse(), new[] { 2, 1, 3 });
    }

    [Fact]
    public void EmptyList()
    {
        TestUtils.EqualSequences(new int[] { }.Reverse(), new int[] { });
    }
}
