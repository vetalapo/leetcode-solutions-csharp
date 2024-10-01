using NUnit.Framework;

using Problems;

public class PowerOfTwoTests
{
    [TestCase( 1, ExpectedResult = true )]
    [TestCase( 3, ExpectedResult = false )]
    [TestCase( 8, ExpectedResult = true )]
    [TestCase( 16, ExpectedResult = true )]
    public bool IsPowerOfTwoTest( int n ) =>
        new PowerOfTwo().IsPowerOfTwo( n );
}
