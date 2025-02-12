using NUnit.Framework;

using Problems;

public class PercentageOfLetterInStringTests
{
    [TestCase( "foobar", 'o', ExpectedResult = 33 )]
    [TestCase( "jjjj", 'k', ExpectedResult = 0 )]
    public int PercentageLetterTest( string s, char letter ) =>
        new PercentageOfLetterInString().PercentageLetter( s, letter );
}
