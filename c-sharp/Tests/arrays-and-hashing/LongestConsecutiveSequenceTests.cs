using NUnit.Framework;

using Problems;

public class LongestConsecutiveSequenceTests
{
    [TestCase(new object[] { new int[] { 100, 4, 200, 1, 3, 2 } }, ExpectedResult = 4 )]
    [TestCase(new object[] { new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 } }, ExpectedResult = 9 )]
    public int LongestConsecutiveTest( int[] nums ) =>
        new LongestConsecutiveSequence().LongestConsecutive( nums );
}
