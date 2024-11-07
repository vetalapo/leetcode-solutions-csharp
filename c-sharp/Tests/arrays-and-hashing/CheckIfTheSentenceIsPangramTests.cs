using System.Collections;

using NUnit.Framework;

namespace Problems;

public class CheckIfTheSentenceIsPangramTests
{
    [TestCaseSource( nameof( TestValues ) )]
    public bool CheckIfPangramTest( string sentence ) =>
        new CheckIfTheSentenceIsPangram().CheckIfPangram( sentence );

    [TestCaseSource( nameof( TestValues ) )]
    public bool CheckIfPangramCountCheckTest( string sentence ) =>
        new CheckIfTheSentenceIsPangram().CheckIfPangramCountCheck( sentence );

    private static IEnumerable TestValues
    {
        get
        {
            yield return new TestCaseData( "thequickbrownfoxjumpsoverthelazydog" ).Returns( true );
            
            yield return new TestCaseData( "leetcode" ).Returns( false );
        }
    }
}
