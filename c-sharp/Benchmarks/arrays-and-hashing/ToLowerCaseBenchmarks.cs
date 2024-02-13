using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using Problems;

namespace Benchmarks;

[MemoryDiagnoser]
[Orderer( SummaryOrderPolicy.FastestToSlowest )]
[RankColumn]
public class ToLowerCaseBenchmarks
{
    private static readonly ToLowerCaseSolution _toLowerCaseSolution = new();

    private static readonly string _testString =
        "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";

    [Benchmark]
    public void ToLowerCase() => _toLowerCaseSolution.ToLowerCase( _testString );

    [Benchmark]
    public void ToLowerCaseSB() => _toLowerCaseSolution.ToLowerCaseSB( _testString );
}
