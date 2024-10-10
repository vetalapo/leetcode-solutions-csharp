using NUnit.Framework;

using Problems;

public class LengthOfLongestSubarrayWithAtMostKFrequencyTests
{
    [TestCase( new int[] { 1, 2, 3, 1, 2, 3, 1, 2 }, 2, ExpectedResult = 6 )]
    [TestCase( new int[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 1, ExpectedResult = 2 )]
    [TestCase( new int[] { 5, 5, 5, 5, 5, 5, 5 }, 4, ExpectedResult = 4 )]
    public int MaxSubarrayLengthTest( int[] nums, int k ) =>
        new LengthOfLongestSubarrayWithAtMostKFrequency().MaxSubarrayLength( nums, k );
}
