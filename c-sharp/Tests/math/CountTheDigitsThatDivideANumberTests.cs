using NUnit.Framework;

using Problems;
public class CountTheDigitsThatDivideANumberTests
{
    [TestCase( 7, ExpectedResult = 1 )]
    [TestCase( 121, ExpectedResult = 2 )]
    [TestCase( 1248, ExpectedResult = 4 )]
    public int CountDigitsTest( int num ) =>
        new CountTheDigitsThatDivideANumber().CountDigits( num );
}
