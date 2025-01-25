using NUnit.Framework;

using Problems;

public class MinimumNumberGameTests
{
    [TestCase( new int[] { 5, 4, 2, 3 }, ExpectedResult = new int[] { 3, 2, 5, 4 } )]
    [TestCase( new int[] { 2, 5 }, ExpectedResult = new int[] { 5, 2 } )]
    public int[] NumberGameTest( int[] nums ) =>
        new MinimumNumberGame().NumberGame( nums );
}
