using NUnit.Framework;

using Problems;

public class ScoreOfAStringTests
{
    [TestCase( "hello", ExpectedResult = 13 )]
    [TestCase( "zaz", ExpectedResult = 50 )]
    public int ScoreOfStringTest( string s ) =>
        new ScoreOfAString().ScoreOfString( s );
}
