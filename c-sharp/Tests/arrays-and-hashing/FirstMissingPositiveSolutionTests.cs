using System.Collections;

using NUnit.Framework;

using Problems;

public class FirstMissingPositiveSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int FirstMissingPositiveTest( int[] nums ) =>
        new FirstMissingPositiveSolution().FirstMissingPositive( nums );

    [TestCaseSource( nameof( TestCases ) )]
    public int FirstMissingPositiveHashSetTest( int[] nums ) =>
        new FirstMissingPositiveSolution().FirstMissingPositiveHashSet( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[] { 1, 2, 0 }] ).Returns( 3 );
            yield return new TestCaseData( [new int[] { 3, 4, -1, 1 }] ).Returns( 2 );
            yield return new TestCaseData( [new int[] { 7, 8, 9, 11, 12 }] ).Returns( 1 );
        }
    }
}
