using NUnit.Framework;

using Problems;

public class FindTheHighestAltitudeTests
{
    [TestCase( new int[] { -5, 1, 5, 0, -7 }, ExpectedResult = 1 )]
    [TestCase( new int[] { -4, -3, -2, -1, 4, 3, 2 }, ExpectedResult = 0 )]
    public int LargestAltitudeTest( int[] gain ) =>
        new FindTheHighestAltitude().LargestAltitude( gain );
}
