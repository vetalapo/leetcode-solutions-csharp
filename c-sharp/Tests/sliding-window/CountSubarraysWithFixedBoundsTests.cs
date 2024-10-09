using NUnit.Framework;

using Problems;

public class CountSubarraysWithFixedBoundsTests
{
    [TestCase( new int[] { 1, 3, 5, 2, 7, 5 }, 1, 5, ExpectedResult = 2 )]
    [TestCase( new int[] { 1, 1, 1, 1 }, 1, 1, ExpectedResult = 10 )]
    public long CountSubarraysTest( int[] nums, int minK, int maxK ) =>
        new CountSubarraysWithFixedBounds().CountSubarrays( nums, minK, maxK );
}
