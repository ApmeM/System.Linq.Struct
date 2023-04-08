// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class WhereTest
{
    [Fact]
    public void ListContainsValuesByCondition()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3 }.Where(c => c > 1), new[] { 2, 3 });
    }

    [Fact]
    public void UsingLocalVariable()
    {
        var local = 6;
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4, 5, 6 }.Where(c => c == local), new[] { 6 });
    }

    [Fact]
    public void ListDoesNotContainValue()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4, 5, 6 }.Where(c => c > 10), new int[] { });
    }
}
