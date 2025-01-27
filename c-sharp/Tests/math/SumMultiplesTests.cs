using NUnit.Framework;

using Problems;

public class SumMultiplesTests
{
    [TestCase( 7, ExpectedResult = 21 )]
    [TestCase( 10, ExpectedResult = 40 )]
    [TestCase( 9, ExpectedResult = 30 )]
    public int SumOfMultiplesTest( int n ) =>
        new SumMultiples().SumOfMultiples( n );
}
