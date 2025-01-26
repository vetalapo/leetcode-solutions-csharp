using NUnit.Framework;

using Problems;

public class ShuffleStringTests
{
    [TestCase( "codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 }, ExpectedResult = "leetcode" )]
    [TestCase( "abc", new int[] { 0, 1, 2 }, ExpectedResult = "abc" )]
    public string RestoreStringTest( string s, int[] indices ) =>
        new ShuffleString().RestoreString( s, indices );
}
