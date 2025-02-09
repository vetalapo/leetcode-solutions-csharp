using NUnit.Framework;

using Problems;

public class UniqueMorseCodeWordsTests
{
    [TestCase( [new string[] { "gin", "zen", "gig", "msg" }], ExpectedResult = 2 )]
    [TestCase( [new string[] { "a" }], ExpectedResult = 1 )]
    public int UniqueMorseRepresentationsTest( string[] words )
        => new UniqueMorseCodeWords().UniqueMorseRepresentations( words );
}
