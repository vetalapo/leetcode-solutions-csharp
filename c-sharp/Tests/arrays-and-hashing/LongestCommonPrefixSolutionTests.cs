using System.Collections;

using NUnit.Framework;

using Problems;

public class LongestCommonPrefixSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public string LongestCommonPrefixTest( string[] strs ) =>
        new LongestCommonPrefixSolution().LongestCommonPrefix( strs );


    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new object[] { new string[] { "flower", "flow", "flight" } } ).Returns( "fl" );

            yield return new TestCaseData( new object[] { new string[] { "flower", "flower", "flower" } } ).Returns( "flower" );

            yield return new TestCaseData( new object[] { new string[] { "dog", "racecar", "car" } } ).Returns( string.Empty );
        }
    }
}
