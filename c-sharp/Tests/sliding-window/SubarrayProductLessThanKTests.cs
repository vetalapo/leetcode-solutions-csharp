using NUnit.Framework;

using Problems;

public class SubarrayProductLessThanKTests
{
    [TestCase( new int[] { 10, 5, 2, 6 }, 100, ExpectedResult = 8 )]
    [TestCase( new int[] { 1, 2, 3 }, 0, ExpectedResult = 0 )]
    public int NumSubarrayProductLessThanKTest( int[] nums, int k )
        => new SubarrayProductLessThanK().NumSubarrayProductLessThanK( nums, k );
}
