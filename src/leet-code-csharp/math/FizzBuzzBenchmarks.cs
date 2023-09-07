using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace leet_code_csharp.math;

[MemoryDiagnoser]
[Orderer( SummaryOrderPolicy.FastestToSlowest )]
[RankColumn]
public class FizzBuzzBenchmarks
{
    private static readonly FizzBuzzSolution FizzBussSolution = new();
    private static readonly int IterationNumber = 1000;

    [Benchmark( Baseline = true )]
    public void FizzBuzz() => FizzBussSolution.FizzBuzz( IterationNumber );

    [Benchmark]
    public void FizzBuzzBooleans() => FizzBussSolution.FizzBuzzBooleans( IterationNumber );
    
    [Benchmark]
    public void FizzBuzzBooleansBackedByArray() => FizzBussSolution.FizzBuzzBooleansBackedByArray( IterationNumber );

    [Benchmark]
    public void FizzBuzzBooleansAndPreallocatedStrings() => FizzBussSolution.FizzBuzzBooleansAndPreallocatedStrings( IterationNumber );

    [Benchmark]
    public void FizzBuzzStringConcatenation() => FizzBussSolution.FizzBuzzStringConcatenation( IterationNumber );

    [Benchmark]
    public void FizzBuzzStringBuilder() => FizzBussSolution.FizzBuzzStringBuilder( IterationNumber );
}
