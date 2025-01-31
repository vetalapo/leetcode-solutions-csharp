using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class CountPairsWhoseSumIsLessThanTargetTests
{
    [TestCase( new int[] { -1, 1, 2, 3, 1 }, 2, ExpectedResult = 3 )]
    [TestCase( new int[] { -6, 2, 5, -2, -7, -1, 3 }, -2, ExpectedResult = 10 )]
    public int CountPairsTest( IList<int> nums, int target ) =>
        new CountPairsWhoseSumIsLessThanTarget().CountPairs( nums, target );
}
