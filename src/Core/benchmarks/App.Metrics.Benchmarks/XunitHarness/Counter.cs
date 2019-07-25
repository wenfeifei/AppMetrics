﻿// <copyright file="Counter.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using App.Metrics.Benchmarks.BenchmarkDotNetBenchmarks.Metrics;
using App.Metrics.Benchmarks.Support;
using Xunit;
using Xunit.Abstractions;

namespace App.Metrics.Benchmarks.XunitHarness
{
    [Trait("Benchmark-MetricType", "Counter")]
    public class Counter
    {
        private readonly ITestOutputHelper _output;

        public Counter(ITestOutputHelper output) { _output = output; }

        [Fact]
        public void CostOfMeasuringCounter() { BenchmarkTestRunner.CanCompileAndRun<MeasureCounterWithMetricItemBenchmark>(_output); }
    }
}