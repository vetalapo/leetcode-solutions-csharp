using NUnit.Framework;

using Problems;

public class SubarraysWithKDifferentIntegersTests
{
    [TestCase( new int[] { 1, 2, 1, 2, 3 }, 2, ExpectedResult = 7 )]
    [TestCase( new int[] { 1, 2, 1, 3, 4 }, 3, ExpectedResult = 3 )]
    public int SubarraysWithKDistinctTest( int[] nums, int k ) =>
        new SubarraysWithKDifferentIntegers().SubarraysWithKDistinct( nums, k );
}
