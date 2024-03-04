using NUnit.Framework;

using Problems;

public class BagOfTokensTests
{
    [TestCase( new int[] { 100 }, 50, ExpectedResult = 0 )]
    [TestCase( new int[] { 200, 100 }, 150, ExpectedResult = 1 )]
    [TestCase( new int[] { 100, 200, 300, 400 }, 200, ExpectedResult = 2 )]
    public int BagOfTokensScoreTest( int[] tokens, int power )
        => new BagOfTokens().BagOfTokensScore( tokens, power );
}
