using System.Collections;

using NUnit.Framework;

using Problems;

public class FinalValueOfVariableAfterPerformingOperationsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int FinalValueAfterOperationsTest( string[] operations ) =>
        new FinalValueOfVariableAfterPerformingOperations().FinalValueAfterOperations( operations );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new object[] { new string[] { "--X", "X++", "X++" } } ).Returns( 1 );
            yield return new TestCaseData( new object[] { new string[] { "++X", "++X", "X++" } } ).Returns( 3 );
            yield return new TestCaseData( new object[] { new string[] { "X++", "++X", "--X", "X--" } } ).Returns( 0 );
        }
    }
}
