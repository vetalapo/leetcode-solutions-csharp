using NUnit.Framework;

using Problems;

[TestFixture]
public class DivisibleAndNonDivisibleSumsDifferenceTests
{
    [TestCase( 10, 3, ExpectedResult = 19 )]
    [TestCase( 5, 6, ExpectedResult = 15 )]
    [TestCase( 5, 1, ExpectedResult = -15 )]
    public int DifferenceOfSumsTest( int n, int m ) => new DivisibleAndNonDivisibleSumsDifference().DifferenceOfSums( n, m );
}
