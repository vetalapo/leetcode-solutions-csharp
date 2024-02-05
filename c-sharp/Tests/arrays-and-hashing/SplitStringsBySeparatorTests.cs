using System.Collections;

using NUnit.Framework;

using Problems;

public class SplitStringsBySeparatorTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<string> SplitWordsBySeparatorTest( IList<string> words, char separator ) =>
        new SplitStringsBySeparator().SplitWordsBySeparator( words, separator );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new List<string>() { "one.two.three", "four.five", "six" }, '.' )
                .Returns( new List<string>() { "one", "two", "three", "four", "five", "six" } );

            yield return new TestCaseData( new List<string>() { "$easy$", "$problem$" }, '$' )
                .Returns( new List<string>() { "easy", "problem" } );

            yield return new TestCaseData( new List<string>() { "|||" }, '|' )
                .Returns( new List<string>() { } );
        }
    }
}
