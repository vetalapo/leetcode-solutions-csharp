using NUnit.Framework;

using Problems;

public class BinarySearchSolutionTests
{
    [TestCase( new int[] { -1, 0, 3, 5, 9, 12 }, 9, ExpectedResult = 4 )]
    [TestCase( new int[] { -1, 0, 3, 5, 9, 12 }, 2, ExpectedResult = -1 )]
    [TestCase( new int[] { 5 }, 5, ExpectedResult = 0 )]
    [TestCase( new int[] { 2, 5 }, 5, ExpectedResult = 1 )]
    public int SearchTest( int[] nums, int target ) =>
        new BinarySearchSolution().Search( nums, target );
}
