using System.Collections;

using NUnit.Framework;

using Problems;

public class BitwiseANDofNumbersRangeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int RangeBitwiseAndTest( int left, int right ) => new BitwiseANDofNumbersRange().RangeBitwiseAnd( left, right );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 0, 0 ).Returns( 0 );
            yield return new TestCaseData( 0, 1 ).Returns( 0 );
            yield return new TestCaseData( 1, 1 ).Returns( 1 );
            yield return new TestCaseData( 2, 5 ).Returns( 0 );
            yield return new TestCaseData( 5, 7 ).Returns( 4 );
            yield return new TestCaseData( 1, 2147483647 ).Returns( 0 );
        }
    }
}
