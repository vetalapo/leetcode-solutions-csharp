using NUnit.Framework;

using Problems;

public class BinarySubarraysWithSumTests
{
    [TestCase( new int[] { 1, 0, 1, 0, 1 }, 2, ExpectedResult = 4 )]
    [TestCase( new int[] { 0, 0, 0, 0, 0 }, 0, ExpectedResult = 15 )]
    public int NumSubarraysWithSumTest( int[] nums, int goal ) =>
        new BinarySubarraysWithSum().NumSubarraysWithSum( nums, goal );
}
