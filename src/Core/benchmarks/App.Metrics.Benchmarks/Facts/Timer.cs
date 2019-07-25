﻿// <copyright file="Timer.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using App.Metrics.Benchmarks.Fixtures;
using App.Metrics.Benchmarks.Support;
using Xunit;

namespace App.Metrics.Benchmarks.Facts
{
    public class Timer : IClassFixture<MetricsCoreTestFixture>
    {
        private readonly MetricsCoreTestFixture _fixture;

        public Timer(MetricsCoreTestFixture fixture) { _fixture = fixture; }

        [Fact]
        public void AlorithmR()
        {
            SimpleBenchmarkRunner.Run(
                () =>
                {
                    _fixture.Metrics.Measure.Timer.Time(
                        MetricOptions.Timer.OptionsAlgorithmR,
                        _fixture.ActionToTrack,
                        _fixture.RandomUserValue);
                });
        }

        [Fact]
        public void ForwardDecaying()
        {
            SimpleBenchmarkRunner.Run(
                () =>
                {
                    _fixture.Metrics.Measure.Timer.Time(
                        MetricOptions.Timer.OptionsForwardDecaying,
                        _fixture.ActionToTrack,
                        _fixture.RandomUserValue);
                });
        }

        [Fact]
        public void SlidingWindow()
        {
            SimpleBenchmarkRunner.Run(
                () =>
                {
                    _fixture.Metrics.Measure.Timer.Time(
                        MetricOptions.Timer.OptionsSlidingWindow,
                        _fixture.ActionToTrack,
                        _fixture.RandomUserValue);
                });
        }
    }
}