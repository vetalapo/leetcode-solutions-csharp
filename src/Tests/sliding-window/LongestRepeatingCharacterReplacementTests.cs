using NUnit.Framework;

using Problems;

[TestFixture]
public class LongestRepeatingCharacterReplacementTests
{
    [TestCase( "ABAB", 2, ExpectedResult = 4 )]
    [TestCase( "AABABBA", 1, ExpectedResult = 4 )]
    public int CharacterReplacementTest( string s, int k ) => new LongestRepeatingCharacterReplacement().CharacterReplacement( s, k );
}
