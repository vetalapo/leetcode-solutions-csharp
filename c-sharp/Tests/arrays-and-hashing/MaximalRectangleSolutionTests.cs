using System.Collections;

using NUnit.Framework;

using Problems;

public class MaximalRectangleSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int MaximalRectangleTest( char[][] matrix )
        => new MaximalRectangleSolution().MaximalRectangle( matrix );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [ new char[][] {
                ['1', '0', '1', '0', '0'],
                ['1', '0', '1', '1', '1'],
                ['1', '1', '1', '1', '1'],
                ['1', '0', '0', '1', '0'] } ] ).Returns( 6 );

            yield return new TestCaseData( [new char[][] { ['0'] }] ).Returns( 0 );

            yield return new TestCaseData( [new char[][] { ['1'] }] ).Returns( 1 );
        }
    }
}
