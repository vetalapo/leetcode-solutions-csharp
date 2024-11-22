using System.Collections;

using NUnit.Framework;

using Problems;

public class MinimumNumberOfArrowsToBurstBalloonsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int FindMinArrowShotsTest( int[][] points ) =>
        new MinimumNumberOfArrowsToBurstBalloons().FindMinArrowShots( points );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [10, 16], [2, 8], [1, 6], [7, 12] }] ).Returns( 2 );

            yield return new TestCaseData( [new int[][] { [1, 2], [3, 4], [5, 6], [7, 8] }] ).Returns( 4 );

            yield return new TestCaseData( [new int[][] { [1, 2], [2, 3], [3, 4], [4, 5] }] ).Returns( 2 );

            yield return new TestCaseData( [new int[][] { [-2147483646, -2147483645], [2147483646, 2147483647] }] ).Returns( 2 );
        }
    }
}
