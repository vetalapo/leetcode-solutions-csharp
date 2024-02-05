using NUnit.Framework;

using Problems;

public class FindMinimumInRotatedSortedArrayTests
{
    [TestCase( new int[] { 3, 4, 5, 1, 2 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 4, 5, 6, 7, 0, 1, 2 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 11, 13, 15, 17 }, ExpectedResult = 11 )]
    [TestCase( new int[] { 3, 1, 2 }, ExpectedResult = 1 )]
    public int FindMinTest( int[] nums ) => new FindMinimumInRotatedSortedArray().FindMin( nums );
}
