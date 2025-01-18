using NUnit.Framework;

using Problems;

public class MergeStringsAlternatelyTests
{
    [TestCase( "abc", "pqr", ExpectedResult = "apbqcr" )]
    [TestCase( "ab", "pqrs", ExpectedResult = "apbqrs" )]
    [TestCase( "abcd", "pq", ExpectedResult = "apbqcd" )]
    public string MergeAlternatelyTest( string word1, string word2 ) =>
        new MergeStringsAlternately().MergeAlternately( word1, word2 );
}
