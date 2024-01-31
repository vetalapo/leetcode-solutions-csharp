using NUnit.Framework;

using Problems;

public class PalindromeNumberTests
{
    [TestCase( 121, ExpectedResult = true )]
    [TestCase( -121, ExpectedResult = false )]
    [TestCase( 10, ExpectedResult = false )]
    public bool IsPalindromeTest( int x ) => new PalindromeNumber().IsPalindrome( x );
}
