using NUnit.Framework;

using Problems;

public class TrappingRainWaterTests
{
    [TestCase( new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 4, 2, 0, 3, 2, 5 }, ExpectedResult = 9 )]
    [TestCase( new int[] { 4, 2, 3 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 5, 5, 1, 7, 1, 1, 5, 2, 7, 6 }, ExpectedResult = 23 )]
    [TestCase( new int[] { 4, 4, 4, 7, 1, 0 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 0, 7, 1, 4, 6 }, ExpectedResult = 7 )]
    public int TrapTest( int[] height ) => new TrappingRainWater().Trap( height );
}