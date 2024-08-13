using NUnit.Framework;

using Problems;

public class LengthOfLastWordSolutionTests
{
    [TestCase( "Hello World", ExpectedResult = 5 )]
    [TestCase( "   fly me   to   the moon  ", ExpectedResult = 4 )]
    [TestCase( "luffy is still joyboy", ExpectedResult = 6 )]
    public int LengthOfLastWordTest( string s ) =>
        new LengthOfLastWordSolution().LengthOfLastWord( s );
}
