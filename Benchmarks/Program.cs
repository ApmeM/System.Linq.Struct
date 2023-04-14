using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CodegenAnalysis;
using CodegenAnalysis.Benchmarks;
using Iced.Intel;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

BenchmarkRunner.Run<DifferentLengths>();
