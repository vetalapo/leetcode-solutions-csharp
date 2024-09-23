using NUnit.Framework;

using Problems;

public class AddDigitsSolutionTests
{
    [TestCase( 0, ExpectedResult = 0 )]
    [TestCase( 16, ExpectedResult = 7 )]
    [TestCase( 38, ExpectedResult = 2 )]
    [TestCase( 942, ExpectedResult = 6 )]
    [TestCase( 132189, ExpectedResult = 6 )]
    [TestCase( 493193, ExpectedResult = 2 )]
    public int AddDigitsTest( int num ) =>
        new AddDigitsSolution().AddDigits( num );
}
