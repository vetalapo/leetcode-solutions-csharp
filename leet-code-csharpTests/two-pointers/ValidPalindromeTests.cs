using NUnit.Framework;

namespace leet_code_csharp.two_pointers.Tests;

[TestFixture]
public class ValidPalindromeTests
{
    [TestCase( "A man, a plan, a canal: Panama", ExpectedResult = true )]
    [TestCase( "race a car", ExpectedResult = false )]
    [TestCase( " ", ExpectedResult = true )]
    [TestCase( "0P", ExpectedResult = false )]
    public bool IsPalindromeTest( string s ) => new ValidPalindrome().IsPalindrome( s );
}