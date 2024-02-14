using NUnit.Framework;

using Problems;

public class LeftAndRightSumDifferencesTests
{
    [TestCase( new int[] { 10, 4, 8, 3 }, ExpectedResult = new int[] { 15, 1, 11, 22 } )]
    [TestCase( new int[] { 1 }, ExpectedResult = new int[] { 0 } )]
    public int[] LeftRightDifferenceTest( int[] nums ) => new LeftAndRightSumDifferences().LeftRightDifference( nums );
}
