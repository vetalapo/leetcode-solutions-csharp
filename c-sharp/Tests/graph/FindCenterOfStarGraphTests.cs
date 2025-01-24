using System.Collections;

using NUnit.Framework;

using Problems;

public class FindCenterOfStarGraphTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int FindCenterTest( int[][] edges ) =>
        new FindCenterOfStarGraph().FindCenter( edges );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 2], [2, 3], [4, 2] }] ).Returns( 2 );

            yield return new TestCaseData( [new int[][] { [1, 2], [5, 1], [1, 3], [1, 4] }] ).Returns( 1 );
        }
    }
}
