using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using Problems;

namespace Benchmarks;

[MemoryDiagnoser]
[Orderer( SummaryOrderPolicy.FastestToSlowest )]
[RankColumn]
public class NumberOfStepsToReduceANumberToZeroBenchmarks
{
    private static readonly NumberOfStepsToReduceANumberToZero NumberOfStepsToReduceANumberToZeroSolution = new();
    private static readonly int IterationNumber = 10000000;

    [Benchmark( Baseline = true )]
    public void NumberOfSteps() => NumberOfStepsToReduceANumberToZeroSolution.NumberOfSteps( IterationNumber );

    [Benchmark]
    public void NumberOfStepsBitwise() => NumberOfStepsToReduceANumberToZeroSolution.NumberOfStepsBitwise( IterationNumber );
}
