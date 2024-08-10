using NUnit.Framework;

using Problems;

public class IsomorphicStringsTests
{
    [TestCase( "egg", "add", ExpectedResult = true )]
    [TestCase( "foo", "bar", ExpectedResult = false )]
    [TestCase( "paper", "title", ExpectedResult = true )]
    public bool IsIsomorphicTest( string s, string t ) =>
        new IsomorphicStrings().IsIsomorphic( s, t );
}
