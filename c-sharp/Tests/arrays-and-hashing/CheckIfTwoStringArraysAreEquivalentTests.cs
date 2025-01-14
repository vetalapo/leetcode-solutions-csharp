using NUnit.Framework;

using Problems;

public class CheckIfTwoStringArraysAreEquivalentTests
{
    [TestCase( new string[] { "ab", "c" }, new string[] { "a", "bc" }, ExpectedResult = true )]
    [TestCase( new string[] { "a", "cb" }, new string[] { "ab", "c" }, ExpectedResult = false )]
    [TestCase( new string[] { "abc", "d", "defg" }, new string[] { "abcddefg" }, ExpectedResult = true )]
    public bool ArrayStringsAreEqualTest( string[] word1, string[] word2 ) =>
        new CheckIfTwoStringArraysAreEquivalent().ArrayStringsAreEqual( word1, word2 );
}
