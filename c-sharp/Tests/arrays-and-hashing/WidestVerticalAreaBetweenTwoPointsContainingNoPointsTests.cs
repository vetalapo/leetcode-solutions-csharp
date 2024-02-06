using System.Collections;

using NUnit.Framework;

using Problems;

public class WidestVerticalAreaBetweenTwoPointsContainingNoPointsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int MaxWidthOfVerticalAreaTest( int[][] points ) =>
        new WidestVerticalAreaBetweenTwoPointsContainingNoPoints().MaxWidthOfVerticalArea( points );

    [TestCaseSource( nameof( TestCases ) )]
    public int MaxWidthOfVerticalAreaSortInPlaceTest( int[][] points ) =>
        new WidestVerticalAreaBetweenTwoPointsContainingNoPoints().MaxWidthOfVerticalAreaSortInPlace( points );


    [TestCaseSource( nameof( TestCases ) )]
    public int MaxWidthOfVerticalAreaExtractAndSortInPlaceTest( int[][] points ) =>
        new WidestVerticalAreaBetweenTwoPointsContainingNoPoints().MaxWidthOfVerticalAreaExtractAndSortInPlace( points );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new object[] { new int[][] { [8, 7], [9, 9], [7, 4], [9, 7] } } )
                .Returns( 1 );

            yield return new TestCaseData( new object[] { new int[][] { [3, 1], [9, 0], [1, 0], [1, 4], [5, 3], [8, 8] } } )
                .Returns( 3 );
        }
    }
}
