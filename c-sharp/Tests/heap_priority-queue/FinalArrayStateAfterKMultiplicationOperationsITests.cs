using System.Collections;

using NUnit.Framework;

using Problems;

public class FinalArrayStateAfterKMultiplicationOperationsITests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[] GetFinalStateTest( int[] nums, int k, int multiplier ) =>
        new FinalArrayStateAfterKMultiplicationOperationsI().GetFinalState( nums, k, multiplier );

    [TestCaseSource( nameof( TestCases ) )]
    public int[] GetFinalStateBFTest( int[] nums, int k, int multiplier ) =>
        new FinalArrayStateAfterKMultiplicationOperationsI().GetFinalStateBF( nums, k, multiplier );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 2, 1, 3, 5, 6 }, 5, 2 ).Returns( new int[] { 8, 4, 6, 5, 6 } );

            yield return new TestCaseData( new int[] { 1, 2 }, 3, 4 ).Returns( new int[] { 16, 8 } );
        }
    }
}
