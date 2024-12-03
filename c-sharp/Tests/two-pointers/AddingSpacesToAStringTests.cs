using NUnit.Framework;

using Problems;

public class AddingSpacesToAStringTests
{
    [TestCase( "LeetcodeHelpsMeLearn", new int[] { 8, 13, 15 }, ExpectedResult = "Leetcode Helps Me Learn" )]
    [TestCase( "icodeinpython", new int[] { 1, 5, 7, 9 }, ExpectedResult = "i code in py thon" )]
    [TestCase( "spacing", new int[] { 0, 1, 2, 3, 4, 5, 6 }, ExpectedResult = " s p a c i n g" )]
    public string AddSpacesTest( string s, int[] spaces ) =>
        new AddingSpacesToAString().AddSpaces( s, spaces );
}
