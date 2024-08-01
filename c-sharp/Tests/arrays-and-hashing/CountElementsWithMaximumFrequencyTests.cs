using NUnit.Framework;

using Problems;

public class CountElementsWithMaximumFrequencyTests
{
    [TestCase( new int[] { 1, 2, 2, 3, 1, 4 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 5 )]
    public int MaxFrequencyElementsTest( int[] nums ) =>
        new CountElementsWithMaximumFrequency().MaxFrequencyElements( nums );
}
