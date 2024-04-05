using NUnit.Framework;

using Problems;

public class MakeTheStringGreatTests
{
    [TestCase( "leEeetcode", ExpectedResult = "leetcode" )]
    [TestCase( "abBAcC", ExpectedResult = "" )]
    [TestCase( "s", ExpectedResult = "s" )]
    public string MakeGoodTest( string s )
        => new MakeTheStringGreat().MakeGood( s );
}
