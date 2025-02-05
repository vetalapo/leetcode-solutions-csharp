using NUnit.Framework;

using Problems;

public class CheckIfOneStringSwapCanMakeStringsEqualTests
{
    [TestCase( "bank", "kanb", ExpectedResult = true )]
    [TestCase( "attack", "defend", ExpectedResult = false )]
    [TestCase( "kelb", "kelb", ExpectedResult = true )]
    [TestCase( "abcd", "dcba", ExpectedResult = false )]
    [TestCase( "aa", "ac", ExpectedResult = false )]
    [TestCase( "caa", "aaz", ExpectedResult = false )]
    [TestCase( "npv", "zpn", ExpectedResult = false )]
    public bool AreAlmostEqualTest( string s1, string s2 ) =>
        new CheckIfOneStringSwapCanMakeStringsEqual().AreAlmostEqual( s1, s2 );
}
