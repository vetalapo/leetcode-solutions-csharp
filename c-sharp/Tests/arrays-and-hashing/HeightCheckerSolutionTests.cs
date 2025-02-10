using NUnit.Framework;

using Problems;

public class HeightCheckerSolutionTests
{
    [TestCase( new int[] { 1, 1, 4, 2, 1, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 5, 1, 2, 3, 4 }, ExpectedResult = 5 )]
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 0 )]
    public int HeightCheckerTest( int[] heights ) =>
        new HeightCheckerSolution().HeightChecker( heights );
}
