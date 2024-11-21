using System.Collections;

using NUnit.Framework;

using Problems;

public class MissingNumberSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int MissingNumberTest( int[] nums ) =>
        new MissingNumberSolution().MissingNumber( nums );

    [TestCaseSource( nameof( TestCases ) )]
    public int MissingNumberSubtractionTest( int[] nums ) =>
        new MissingNumberSolution().MissingNumberSubtraction( nums );

    [TestCaseSource( nameof( TestCases ) )]
    public int MissingNumberMathTest( int[] nums ) =>
        new MissingNumberSolution().MissingNumberMath( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 3, 0, 1 } ).Returns( 2 );
            
            yield return new TestCaseData( new int[] { 0, 1 } ).Returns( 2 );
            
            yield return new TestCaseData( new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 } ).Returns( 8 );
        }
    }
}
