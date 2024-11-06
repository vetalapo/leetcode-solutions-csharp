using NUnit.Framework;

using Problems;

public class ValidPalindromeTests
{
    [TestCase( "A man, a plan, a canal: Panama", ExpectedResult = true )]
    [TestCase( "race a car", ExpectedResult = false )]
    [TestCase( " ", ExpectedResult = true )]
    [TestCase( "0P", ExpectedResult = false )]
    public bool IsPalindromeTest( string s ) =>
        new ValidPalindrome().IsPalindrome( s );
}
