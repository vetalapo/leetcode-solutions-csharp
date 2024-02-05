using NUnit.Framework;

using Problems;

public class FirstLetterToAppearTwiceTests
{
    [TestCase( "abccbaacz", ExpectedResult = 'c' )]
    [TestCase( "abcdd", ExpectedResult = 'd' )]
    public char RepeatedCharacterTest( string s ) => new FirstLetterToAppearTwice().RepeatedCharacter( s );
}
