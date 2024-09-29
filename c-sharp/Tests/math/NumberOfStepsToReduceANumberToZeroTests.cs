using System.Collections;

using NUnit.Framework;

using Problems;

public class NumberOfStepsToReduceANumberToZeroTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int NumberOfStepsTest( int num ) =>
        new NumberOfStepsToReduceANumberToZero().NumberOfSteps( num );

    [TestCaseSource( nameof( TestCases ) )]
    public int NumberOfStepsBitwiseTest( int num ) =>
        new NumberOfStepsToReduceANumberToZero().NumberOfStepsBitwise( num );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 14 ).Returns( 6 );
            yield return new TestCaseData( 8 ).Returns( 4 );
            yield return new TestCaseData( 123 ).Returns( 12 );
            yield return new TestCaseData( 5000000 ).Returns( 30 );
        }
    }
}
