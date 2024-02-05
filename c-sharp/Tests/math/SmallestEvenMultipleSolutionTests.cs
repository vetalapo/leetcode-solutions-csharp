using NUnit.Framework;

using Problems;

public class SmallestEvenMultipleSolutionTests
{
    [TestCase( 5, ExpectedResult = 10 )]
    [TestCase( 6, ExpectedResult = 6 )]
    public int SmallestEvenMultipleTest( int n ) => new SmallestEvenMultipleSolution().SmallestEvenMultiple( n );
}
