using NUnit.Framework;

using Problems;

public class PermutationDifferenceBetweenTwoStringsTests
{
    [TestCase( "abc", "bac", ExpectedResult = 2 )]
    [TestCase( "abcde", "edbac", ExpectedResult = 12 )]
    public int FindPermutationDifferenceTest( string s, string t ) =>
        new PermutationDifferenceBetweenTwoStrings().FindPermutationDifference( s, t );
}
