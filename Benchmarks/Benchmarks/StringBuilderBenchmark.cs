using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class StringBuilderBenchmark
{
    [Benchmark]
    public string GetFullStringNormally()
    {
        string output = string.Empty;

        for (int i = 0; i < 100; i++)
        {
            output += i;
        }

        return output;
    }

    [Benchmark]
    public string GetFullStringWithStringBuilder()
    {
        System.Text.StringBuilder sb = new();

        for (int i = 0; i < 100; i++)
        {
            sb.Append(i);
        }

        return sb.ToString();
    }
}