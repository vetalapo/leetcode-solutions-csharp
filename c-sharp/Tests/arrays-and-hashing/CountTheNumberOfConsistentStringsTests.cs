using NUnit.Framework;

using Problems;

public class CountTheNumberOfConsistentStringsTests
{
    [TestCase( "ab", new string[] { "ad", "bd", "aaab", "baa", "badab" }, ExpectedResult = 2 )]
    [TestCase( "abc", new string[] { "a", "b", "c", "ab", "ac", "bc", "abc" }, ExpectedResult = 7 )]
    [TestCase( "cad", new string[] { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" }, ExpectedResult = 4 )]
    [TestCase( "fstqyienx", new string[] { "n", "eeitfns", "eqqqsfs", "i", "feniqis", "lhoa", "yqyitei", "sqtn", "kug", "z", "neqqis" }, ExpectedResult = 8 )]
    public int CountConsistentStringsTest( string allowed, string[] words ) =>
        new CountTheNumberOfConsistentStrings().CountConsistentStrings( allowed, words );
}
