using System.Collections;

using NUnit.Framework;

using Problems;

public class InsertIntervalTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[][] InsertTest( int[][] intervals, int[] newInterval )
        => new InsertInterval().Insert( intervals, newInterval );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[][] { [1, 3], [6, 9] }, new int[] { 2, 5 } )
                .Returns( new int[][] { [1, 5], [6, 9] } );

            yield return new TestCaseData( new int[][] { [1, 2], [3, 5], [6, 7], [8, 10], [12, 16] }, new int[] { 4, 8 } )
                .Returns( new int[][] { [1, 2], [3, 10], [12, 16] } );
        }
    }
}
