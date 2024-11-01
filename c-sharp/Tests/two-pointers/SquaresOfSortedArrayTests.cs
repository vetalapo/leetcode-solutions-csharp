using NUnit.Framework;

using Problems;

public class SquaresOfSortedArrayTests
{
    [TestCase( new int[] { -4, -1, 0, 3, 10 }, ExpectedResult = new int[] { 0, 1, 9, 16, 100 } )]
    [TestCase( new int[] { -7, -3, 2, 3, 11 }, ExpectedResult = new int[] { 4, 9, 9, 49, 121 } )]
    public int[] SortedSquaresTest( int[] nums ) =>
        new SquaresOfSortedArray().SortedSquares( nums );
}
