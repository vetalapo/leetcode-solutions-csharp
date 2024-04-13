using NUnit.Framework;

using Problems;

public class RemoveKDigitsSolutionTests
{
    [TestCase( "1432219", 3, ExpectedResult = "1219" )]
    [TestCase( "10200", 1, ExpectedResult = "200" )]
    [TestCase( "10", 2, ExpectedResult = "0" )]
    public string RemoveKDigitsTest( string num, int k )
        => new RemoveKDigitsSolution().RemoveKDigits( num, k );
}
