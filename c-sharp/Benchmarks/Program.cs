using BenchmarkDotNet.Running;

namespace Benchmarks;

public class Program
{
    static void Main()
    {
        BenchmarkRunner.Run<ToLowerCaseBenchmarks>();
    }
}
