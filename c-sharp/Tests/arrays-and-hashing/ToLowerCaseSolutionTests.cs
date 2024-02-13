using System.Collections;

using NUnit.Framework;

using Problems;

public class ToLowerCaseSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public string ToLowerCaseTest( string s ) => new ToLowerCaseSolution().ToLowerCase( s );

    [TestCaseSource( nameof( TestCases ) )]
    public string ToLowerCaseSBTest( string s ) => new ToLowerCaseSolution().ToLowerCaseSB( s );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( string.Empty ).Returns( string.Empty );
            yield return new TestCaseData( "Hello" ).Returns( "hello" );
            yield return new TestCaseData( "here" ).Returns( "here" );
            yield return new TestCaseData( "LOVELY" ).Returns( "lovely" );
            yield return new TestCaseData( "al&phaBET" ).Returns( "al&phabet" );
        }
    }
}
