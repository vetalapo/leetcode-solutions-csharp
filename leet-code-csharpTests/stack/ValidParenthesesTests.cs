using NUnit.Framework;

namespace leet_code_csharp.stack.Tests;

[TestFixture]
public class ValidParenthesesTests
{
    [TestCase( "()", ExpectedResult = true )]
    [TestCase( "()[]{}", ExpectedResult = true )]
    [TestCase( "(]", ExpectedResult = false )]
    [TestCase( "{[]}", ExpectedResult = true )]
    [TestCase( "[", ExpectedResult = false )]
    [TestCase( "]", ExpectedResult = false )]
    public bool IsValidTest( string s ) => new ValidParentheses().IsValid( s );
}