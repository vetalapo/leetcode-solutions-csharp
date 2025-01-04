using NUnit.Framework;

using Problems;

public class FindMinimumOperationsToMakeAllElementsDivisibleByThreeTests
{
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 3, 6, 9 }, ExpectedResult = 0 )]
    public int MinimumOperationsTest( int[] nums ) =>
        new FindMinimumOperationsToMakeAllElementsDivisibleByThree().MinimumOperations( nums );
}
