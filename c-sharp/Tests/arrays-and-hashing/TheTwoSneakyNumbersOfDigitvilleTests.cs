using NUnit.Framework;

using Problems;

public class TheTwoSneakyNumbersOfDigitvilleTests
{
    [TestCase( new int[] { 0, 1, 1, 0 }, ExpectedResult = new int[] { 1, 0 } )]
    [TestCase( new int[] { 0, 3, 2, 1, 3, 2 }, ExpectedResult = new int[] { 3, 2 } )]
    [TestCase( new int[] { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 }, ExpectedResult = new int[] { 4, 5 } )]
    public int[] GetSneakyNumbersTest( int[] nums ) =>
        new TheTwoSneakyNumbersOfDigitville().GetSneakyNumbers( nums );
}
