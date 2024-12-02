using System.Collections;

using NUnit.Framework;

using Problems;

public class CheckIfAWordOccursAsAPrefixOfAnyWordInASentenceTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int IsPrefixOfWordTest( string sentence, string searchWord ) =>
        new CheckIfAWordOccursAsAPrefixOfAnyWordInASentence().IsPrefixOfWord( sentence, searchWord );

    [TestCaseSource( nameof( TestCases ) )]
    public int IsPrefixOfWordSplitTest( string sentence, string searchWord ) =>
        new CheckIfAWordOccursAsAPrefixOfAnyWordInASentence().IsPrefixOfWordSplit( sentence, searchWord );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( "i love eating burger", "burg" ).Returns( 4 );

            yield return new TestCaseData( "this problem is an easy problem", "pro" ).Returns( 2 );

            yield return new TestCaseData( "i am tired", "you" ).Returns( -1 );

            yield return new TestCaseData( "i use triple pillow", "pill" ).Returns( 4 );

            yield return new TestCaseData( "hellohello hellohellohello", "ell" ).Returns( -1 );

            yield return new TestCaseData( "leetcode corona", "leetco" ).Returns( 1 );

            yield return new TestCaseData( "i am your dad", "daddy" ).Returns( -1 );

            yield return new TestCaseData( "b bu bur burg burger", "burg" ).Returns( 4 );
        }
    }
}
