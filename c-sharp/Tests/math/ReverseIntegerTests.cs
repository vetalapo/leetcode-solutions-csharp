using NUnit.Framework;

using Problems;

public class ReverseIntegerTests
{
    [TestCase( 123, ExpectedResult = 321 )]
    [TestCase( -123, ExpectedResult = -321 )]
    [TestCase( 120, ExpectedResult = 21 )]
    [TestCase( 1534236469, ExpectedResult = 0 )]
    public int ReverseTest( int x ) => new ReverseInteger().Reverse( x );
}
