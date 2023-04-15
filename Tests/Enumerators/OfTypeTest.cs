// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

namespace Tests.ExtensionsFunctionalTests;

public class OfTypeTest
{
    [Fact]
    public void InitialArrayContainElementsOfType()
    {
        TestUtils.EqualSequences(new object[] { 1L, 2F, 3D }.OfType<object, float>(), new float[] { 2 });
    }

    [Fact]
    public void ListDoesNotHaveElementsOfType()
    {
        TestUtils.EqualSequences(new[] { 1, 2, 3, 4, 5, 6 }.OfType<int, double>(), new double[] { });
    }
}
