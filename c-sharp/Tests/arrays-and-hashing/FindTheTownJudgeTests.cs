using System.Collections;

using NUnit.Framework;

using Problems;

public class FindTheTownJudgeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int FindJudgeTest( int n, int[][] trust ) =>
        new FindTheTownJudge().FindJudge( n, trust );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 2, new int[][] { [1, 2] } ).Returns( 2 );
            
            yield return new TestCaseData( 3, new int[][] { [1, 3], [2, 3] } ).Returns( 3 );
            
            yield return new TestCaseData( 3, new int[][] { [1, 3], [2, 3], [3, 1] } ).Returns( -1 );
        }
    }
}
