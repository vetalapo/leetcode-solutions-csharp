using NUnit.Framework;

using Problems;

public class PlusOneSolutionTests
{
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2, 4 } )]
    [TestCase( new int[] { 4, 3, 2, 1 }, ExpectedResult = new int[] { 4, 3, 2, 2 } )]
    [TestCase( new int[] { 9 }, ExpectedResult = new int[] { 1, 0 } )]
    [TestCase( new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, ExpectedResult = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 } )]
    public int[] PlusOneTest( int[] digits ) =>
        new PlusOneSolution().PlusOne( digits );
}
