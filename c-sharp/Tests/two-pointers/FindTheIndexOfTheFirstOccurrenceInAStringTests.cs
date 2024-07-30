using NUnit.Framework;

using Problems;

public class FindTheIndexOfTheFirstOccurrenceInAStringTests
{
    [TestCase( "sadbutsad", "sad", ExpectedResult = 0 )]
    [TestCase( "leetcode", "leeto", ExpectedResult = -1 )]
    [TestCase( "aaa", "aaaa", ExpectedResult = -1 )]
    [TestCase( "mississippi", "issip", ExpectedResult = 4 )]
    [TestCase( "mississippi", "issipi", ExpectedResult = -1 )]
    [TestCase( "hello", "ll", ExpectedResult = 2 )]
    [TestCase( "a", "a", ExpectedResult = 0 )]
    public int StrStrTest( string haystack, string needle ) =>
        new FindTheIndexOfTheFirstOccurrenceInAString().StrStr( haystack, needle );
}
