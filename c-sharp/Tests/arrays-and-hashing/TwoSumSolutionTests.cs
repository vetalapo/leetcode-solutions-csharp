using NUnit.Framework;

using Problems;

public class TwoSumSolutionTests
{
    [TestCase( new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 } )]
    [TestCase( new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1, 2 } )]
    [TestCase( new int[] { 3, 3 }, 6, ExpectedResult = new int[] { 0, 1 } )]
    [TestCase( new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, ExpectedResult = new int[] { 5, 11 } )]
    public int[] TwoSumTest( int[] nums, int target ) => new TwoSumSolution().TwoSum( nums, target );
}