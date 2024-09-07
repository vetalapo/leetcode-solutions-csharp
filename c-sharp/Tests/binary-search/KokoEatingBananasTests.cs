using NUnit.Framework;

using Problems;

public class KokoEatingBananasTests
{
    [TestCase( new int[] { 3, 6, 7, 11 }, 8, ExpectedResult = 4 )]
    [TestCase( new int[] { 30, 11, 23, 4, 20 }, 5, ExpectedResult = 30 )]
    [TestCase( new int[] { 30, 11, 23, 4, 20 }, 6, ExpectedResult = 23 )]
    [TestCase( new int[] { 805306368, 805306368, 805306368 }, 1000000000, ExpectedResult = 3 )]
    public int MinEatingSpeedTest( int[] piles, int h ) =>
        new KokoEatingBananas().MinEatingSpeed( piles, h );
}
