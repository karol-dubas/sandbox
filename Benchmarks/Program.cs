using BenchmarkDotNet.Running;
using Benchmarks;
using Benchmarks.Benchmarks;
using Benchmarks.Benchmarks.ListVsDictionary;

BenchmarkRunner.Run<ListVsDictionaryBenchmark>();

// Configuration = Release
// Run (Ctrl + F5)