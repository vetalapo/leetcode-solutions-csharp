using NUnit.Framework;

namespace Problems.Tests;

public class ReversePrefixOfWordTests
{
    [TestCase( "abcdefd", 'd', ExpectedResult = "dcbaefd" )]
    [TestCase( "xyxzxe", 'z', ExpectedResult = "zxyxxe" )]
    [TestCase( "abcd", 'z', ExpectedResult = "abcd" )]
    public string ReversePrefixTest( string word, char ch ) =>
        new ReversePrefixOfWord().ReversePrefix( word, ch );
}
