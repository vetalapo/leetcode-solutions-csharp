using System.Collections;

using NUnit.Framework;

namespace leet_code_csharp.arrays_and_hashing.Tests;

[TestFixture]
public class ValidAnagramTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool IsAnagramTest( string s, string t ) => new ValidAnagram().IsAnagram( s, t );

    [TestCaseSource( nameof( TestCases ) )]
    public bool IsAnagramBySortingTest( string s, string t ) => new ValidAnagram().IsAnagramBySorting( s, t );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( "anagram", "nagaram" ).Returns( true );
            yield return new TestCaseData( "rat", "car" ).Returns( false );
        }
    }
}
