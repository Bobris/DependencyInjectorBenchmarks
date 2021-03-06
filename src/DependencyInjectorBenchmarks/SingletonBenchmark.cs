﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using DependencyInjectorBenchmarks.Containers;
using DependencyInjectorBenchmarks.Scenarios;

namespace DependencyInjectorBenchmarks
{
    [Config(typeof(Config))]
    [OrderProvider(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
    public class SingletonBenchmark
    {
        [Benchmark(Baseline = true)]
        public ISingleton Direct() => DirectBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton SimpleInjector() => SimpleInjectorBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton Mef() => MefBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton Ninject() => NinjectBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton Mef2() => Mef2Benchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton CastleWindsor() => CastleWindsorBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton Autofac() => AutofacBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton Unity() => UnityBenchmarks.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton AspNetCore() => AspNetCoreBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton LightInject() => LightInjectBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton StructureMap() => StructureMapBenchmark.Instance.ResolveSingleton();

        [Benchmark]
        public ISingleton BTDB() => BTDBBenchmark.Instance.ResolveSingleton();
    }
}
