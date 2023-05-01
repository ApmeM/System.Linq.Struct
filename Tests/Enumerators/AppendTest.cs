// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class AppendTest
{
    [Fact]
    public void AppendToExistingList()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Append(5), new[] { 1, 2, 3, 5 });
    }

    [Fact]
    public void AppendToEmptyList()
    {
        TestUtils.EqualSequences(new int[] { }.Append(5), new[] { 5 });
    }
}