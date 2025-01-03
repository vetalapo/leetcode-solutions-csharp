using NUnit.Framework;

using Problems;

public class DecodeXORedArrayTests
{
    [TestCase( new int[] { 1, 2, 3 }, 1, ExpectedResult = new int[] { 1, 0, 2, 1 } )]
    [TestCase( new int[] { 6, 2, 7, 3 }, 4, ExpectedResult = new int[] { 4, 2, 0, 7, 4 } )]
    public int[] DecodeTest( int[] encoded, int first ) =>
        new DecodeXORedArray().Decode( encoded, first );
}
