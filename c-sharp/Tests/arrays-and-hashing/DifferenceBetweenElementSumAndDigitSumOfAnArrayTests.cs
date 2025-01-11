using NUnit.Framework;

using Problems;

public class DifferenceBetweenElementSumAndDigitSumOfAnArrayTests
{
    [TestCase( new int[] { 1, 15, 6, 3 }, ExpectedResult = 9 )]
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = 0 )]
    public int DifferenceOfSumTest( int[] nums ) =>
        new DifferenceBetweenElementSumAndDigitSumOfAnArray().DifferenceOfSum( nums );
}
