using NUnit.Framework;

using Problems;

public class FindLuckyIntegerInAnArrayTests
{
    [TestCase( new int[] { }, ExpectedResult = -1 )]
    [TestCase( new int[] { 2, 2, 3, 4 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 1, 2, 2, 3, 3, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 2, 2, 2, 3, 3 }, ExpectedResult = -1 )]
    public int FindLuckyTest( int[] arr ) =>
        new FindLuckyIntegerInAnArray().FindLucky( arr );
}
