using NUnit.Framework;

using Problems;

public class MinimumLengthOfStringAfterDeletingSimilarEndsTests
{
    [TestCase( "c", ExpectedResult = 1 )]
    [TestCase( "ca", ExpectedResult = 2 )]
    [TestCase( "aba", ExpectedResult = 1 )]
    [TestCase( "cabaabac", ExpectedResult = 0 )]
    [TestCase( "aabccabba", ExpectedResult = 3 )]
    [TestCase( "bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb", ExpectedResult = 1 )]
    [TestCase( "abbbbbbbbbbbbbbbbbbba", ExpectedResult = 0 )]
    public int MinimumLengthTest( string s ) =>
        new MinimumLengthOfStringAfterDeletingSimilarEnds().MinimumLength( s );
}
