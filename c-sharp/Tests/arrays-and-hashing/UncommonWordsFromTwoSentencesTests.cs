using NUnit.Framework;

namespace Problems.Tests;

public class UncommonWordsFromTwoSentencesTests
{
    [TestCase( "this apple is sweet", "this apple is sour", ExpectedResult = new string[] { "sweet", "sour" } )]
    [TestCase( "apple apple", "banana", ExpectedResult = new string[] { "banana" } )]
    [TestCase( "this apple is sweet sweet sweet", "this apple is sour", ExpectedResult = new string[] { "sour" } )]
    [TestCase( "this apple is sweet sweet sweet and good", "this apple is sour", ExpectedResult = new string[] { "and", "good", "sour" } )]
    [TestCase( "s z z z s", "s z ejt", ExpectedResult = new string[] { "ejt" } )]
    [TestCase( "", "", ExpectedResult = new string[] { } )]
    public string[] UncommonFromSentencesTest( string s1, string s2 ) =>
        new UncommonWordsFromTwoSentences().UncommonFromSentences( s1, s2 );
}
