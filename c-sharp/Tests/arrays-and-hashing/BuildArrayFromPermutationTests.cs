using NUnit.Framework;

using Problems;

public class BuildArrayFromPermutationTests
{
    [TestCase( new int[] { 0, 2, 1, 5, 3, 4 }, ExpectedResult = new int[] { 0, 1, 2, 4, 5, 3 } )]
    [TestCase( new int[] { 5, 0, 1, 2, 3, 4 }, ExpectedResult = new int[] { 4, 5, 0, 1, 2, 3 } )]
    public int[] BuildArrayTest( int[] nums ) => new BuildArrayFromPermutation().BuildArray( nums );
}
