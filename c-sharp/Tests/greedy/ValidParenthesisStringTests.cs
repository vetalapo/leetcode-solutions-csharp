using NUnit.Framework;

using Problems;

public class ValidParenthesisStringTests
{
    [TestCase( "()", ExpectedResult = true )]
    [TestCase( "(*)", ExpectedResult = true )]
    [TestCase( "(*))", ExpectedResult = true )]
    public bool CheckValidStringTest( string s )
        => new ValidParenthesisString().CheckValidString( s );
}
