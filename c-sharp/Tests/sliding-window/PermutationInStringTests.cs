using NUnit.Framework;

using Problems;

public class PermutationInStringTests
{
    [TestCase( "ab", "eidbaooo", ExpectedResult = true )]
    [TestCase( "ab", "eidboaoo", ExpectedResult = false )]
    [TestCase( "abc", "bbbca", ExpectedResult = true )]
    [TestCase( "hello", "ooolleoooleh", ExpectedResult = false )]
    public bool CheckInclusionTest( string s1, string s2 ) => new PermutationInString().CheckInclusion( s1, s2 );
}
