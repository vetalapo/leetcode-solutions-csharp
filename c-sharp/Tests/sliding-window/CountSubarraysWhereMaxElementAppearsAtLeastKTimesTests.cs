using NUnit.Framework;

using Problems;

public class CountSubarraysWhereMaxElementAppearsAtLeastKTimesTests
{
    [TestCase( new int[] { 1, 3, 2, 3, 3 }, 2, ExpectedResult = 6 )]
    [TestCase( new int[] { 1, 4, 2, 1 }, 3, ExpectedResult = 0 )]
    public long CountSubarraysTest( int[] nums, int k )
        => new CountSubarraysWhereMaxElementAppearsAtLeastKTimes().CountSubarrays( nums, k );
}
