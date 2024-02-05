using NUnit.Framework;

using Problems;

public class ShuffleTheArrayTests
{
    [TestCase( new int[] { 2, 5, 1, 3, 4, 7 }, 3, ExpectedResult = new int[] { 2, 3, 5, 4, 1, 7 } )]
    [TestCase( new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, ExpectedResult = new int[] { 1, 4, 2, 3, 3, 2, 4, 1 } )]
    [TestCase( new int[] { 1, 1, 2, 2 }, 2, ExpectedResult = new int[] { 1, 2, 1, 2 } )]
    public int[] ShuffleTest( int[] nums, int n ) => new ShuffleTheArray().Shuffle( nums, n );
}
