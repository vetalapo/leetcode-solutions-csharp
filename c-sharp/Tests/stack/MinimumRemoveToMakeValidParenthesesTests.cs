using NUnit.Framework;

using Problems;

public class MinimumRemoveToMakeValidParenthesesTests
{
    [TestCase( "lee(t(c)o)de)", ExpectedResult = "lee(t(c)o)de" )]
    [TestCase( "a)b(c)d", ExpectedResult = "ab(c)d" )]
    [TestCase( "))((", ExpectedResult = "" )]
    public string MinRemoveToMakeValidTest( string s )
        => new MinimumRemoveToMakeValidParentheses().MinRemoveToMakeValid( s );
}
