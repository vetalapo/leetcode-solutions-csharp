using System.Collections;

using NUnit.Framework;

using Problems;

public class LargestRectangleInHistogramTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int LargestRectangleAreaTest( int[] heights ) => new LargestRectangleInHistogram().LargestRectangleArea( heights );

    [TestCaseSource( nameof( TestCases ) )]
    public int LargestRectangleExplicitTest( int[] heights ) => new LargestRectangleInHistogram().LargestRectangleExplicit( heights );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 2, 1, 5, 6, 2, 3 } ).Returns( 10 );
            yield return new TestCaseData( new int[] { 2, 4 } ).Returns( 4 );
            yield return new TestCaseData( new int[] { 2, 1, 2 } ).Returns( 3 );
        }
    }
}
