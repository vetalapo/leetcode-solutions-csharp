using NUnit.Framework;

using Problems;

public class SingleNumberProblemTests
{
    [TestCase( new int[] { 2, 2, 1 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 4, 1, 2, 1, 2 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 1 }, ExpectedResult = 1 )]
    public int SingleNumberTest( int[] nums ) =>
        new SingleNumberProblem().SingleNumber( nums );
}
