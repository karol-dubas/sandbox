using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class ForVsForeachBenchmark
{
    private static readonly Random Rng = new(1337);
    
    [Params(10, 1000, 100_000)]
    public int Size { get; set; }

    private List<int> _items;

    [GlobalSetup]
    public void Setup()
    {
        _items = Enumerable.Range(1, Size)
            .Select(i => Rng.Next())
            .ToList();
    }

    [Benchmark]
    public void For()
    {
        for (int i = 0; i < _items.Count; i++)
        {
            int item = _items[i];
        }
    }
    
    [Benchmark]
    public void Foreach()
    {
        foreach (int item in _items) { }
    }
    
    [Benchmark]
    public void ForEach_Method()
    {
        _items.ForEach(i => { });
    }
}