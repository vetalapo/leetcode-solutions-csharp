using System.Collections;

using NUnit.Framework;

using Problems;

[TestFixture]
public class FindWordsContainingCharacterTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<int> FindWordsContainingTest( string[] words, char x ) =>
        new FindWordsContainingCharacter().FindWordsContaining( words, x );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new string[] { "leet", "code" }, 'e' ).Returns( new List<int> { 0, 1 } );
            yield return new TestCaseData( new string[] { "abc", "bcd", "aaaa", "cbc" }, 'a' ).Returns( new List<int> { 0, 2 } );
            yield return new TestCaseData( new string[] { "abc", "bcd", "aaaa", "cbc" }, 'z' ).Returns( new List<int> { } );
        }
    }
}
