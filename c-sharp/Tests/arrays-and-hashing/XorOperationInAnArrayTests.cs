using NUnit.Framework;

using Problems;

public class XorOperationInAnArrayTests
{
    [TestCase( 5, 0, ExpectedResult = 8 )]
    [TestCase( 4, 3, ExpectedResult = 8 )]
    public int XorOperationTest( int n, int start ) =>
        new XorOperationInAnArray().XorOperation( n, start );
}
