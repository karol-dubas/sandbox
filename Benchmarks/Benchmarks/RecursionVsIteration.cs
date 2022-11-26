using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class RecursionVsIteration
{
	[Params(1, 10, 15, 30)]
	public int Size { get; set; }

	[Benchmark]
	public int Recursion()
	{
		return Kata.Kata.RecursiveFib(Size);
	}

	[Benchmark]
	public int Iteration()
	{
		return Kata.Kata.Fib(Size);
	}
}
