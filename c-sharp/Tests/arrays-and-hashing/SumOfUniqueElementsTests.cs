using NUnit.Framework;

using Problems;

public class SumOfUniqueElementsTests
{
    [TestCase( new int[] { 1, 2, 3, 2 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15 )]
    public int SumOfUniqueTest( int[] nums ) =>
        new SumOfUniqueElements().SumOfUnique( nums );
}
