using NUnit.Framework;

using Problems;

public class FindThePivotIntegerTests
{
    [TestCase( 8, ExpectedResult = 6 )]
    [TestCase( 1, ExpectedResult = 1 )]
    [TestCase( 4, ExpectedResult = -1 )]
    public int PivotIntegerTest( int n ) =>
        new FindThePivotInteger().PivotInteger( n );
}
