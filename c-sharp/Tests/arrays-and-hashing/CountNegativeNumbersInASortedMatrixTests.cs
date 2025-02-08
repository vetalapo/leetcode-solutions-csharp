using System.Collections;

using NUnit.Framework;

using Problems;

public class CountNegativeNumbersInASortedMatrixTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int CountNegativesTest( int[][] grid ) =>
        new CountNegativeNumbersInASortedMatrix().CountNegatives( grid );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3] }] ).Returns( 8 );

            yield return new TestCaseData( [new int[][] { [3, 2], [1, 0] }] ).Returns( 0 );
        }
    }
}
