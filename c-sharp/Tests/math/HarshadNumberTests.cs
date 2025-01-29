using NUnit.Framework;

using Problems;

public class HarshadNumberTests
{
    [TestCase( 18, ExpectedResult = 9 )]
    [TestCase( 23, ExpectedResult = -1 )]
    public int SumOfTheDigitsOfHarshadNumberTest( int x ) =>
        new HarshadNumber().SumOfTheDigitsOfHarshadNumber( x );
}
