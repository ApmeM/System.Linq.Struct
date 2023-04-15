using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CodegenAnalysis;
using CodegenAnalysis.Benchmarks;
using Iced.Intel;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// var c = new DifferentLengths();
// c.ArrayLength = 5;
// c.Setup();
// c.StructWithCast();
BenchmarkRunner.Run<DifferentLengths>();
