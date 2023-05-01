// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class PrependTest
{
    [Fact]
    public void ListWithData()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Prepend(5), new[] { 5, 1, 2, 3 });
    }

    [Fact]
    public void EmptyList()
    {
        TestUtils.EqualSequences(new int[] { }.Prepend(5), new[] { 5 });
    }
}