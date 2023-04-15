// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class CastTest
{
    [Fact]
    public void InitialArrayContainElementsOfType()
    {
        TestUtils.EqualSequences(new [] { 1, 2, 3 }.Cast<int, float>(), new float[] { 1, 2, 3 });
    }

    [Fact]
    public void ListDoesNotHaveElementsOfType()
    {
        Assert.Throws<System.InvalidCastException>(() => new object[] { 1L, 2F, 3D }.Cast<object, float>().First());
    }
}
