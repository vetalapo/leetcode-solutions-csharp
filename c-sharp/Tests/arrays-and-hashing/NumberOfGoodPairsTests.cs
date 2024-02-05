using NUnit.Framework;

using Problems;

public class NumberOfGoodPairsTests
{
    [TestCase( new int[] { 1, 2, 3, 1, 1, 3 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 1, 1, 1 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = 0 )]
    public int NumIdenticalPairsTest( int[] nums ) => new NumberOfGoodPairs().NumIdenticalPairs( nums );
}