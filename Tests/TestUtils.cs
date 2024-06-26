﻿// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

global using System.Linq.Struct;
global using Xunit;

using System.Collections.Generic;

namespace Tests;

public static class TestUtils
{
    public static void EqualSequences<T, TEnumerator>(RefLinqEnumerable<T, TEnumerator> en, IEnumerable<T> expected)
        where TEnumerator : IRefEnumerator<T>
    {
        var list = new List<T>();
        foreach (var el in en)
            list.Add(el);
        Assert.Equal(expected, list);
    }
}