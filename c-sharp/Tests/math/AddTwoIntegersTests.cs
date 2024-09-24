using System.Collections;

using NUnit.Framework;

using Problems;

public class AddTwoIntegersTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int SumTest( int num1, int num2 ) =>
        new AddTwoIntegers().Sum( num1, num2 );

    [TestCaseSource( nameof( TestCases ) )]
    public int SumBitManipulationTest( int num1, int num2 ) =>
        new AddTwoIntegers().SumBitManipulation( num1, num2 );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 12, 5 ).Returns( 17 );
            yield return new TestCaseData( -10, 4 ).Returns( -6 );
        }
    }
}
