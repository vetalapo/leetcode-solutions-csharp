using System.Collections;

using NUnit.Framework;

using Problems;

public class CarFleetSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int CarFleetTest( int target, int[] position, int[] speed )
        => new CarFleetSolution().CarFleet( target, position, speed );

    [TestCaseSource( nameof( TestCases ) )]
    public int CarFleetPairsSortTogetherTest( int target, int[] position, int[] speed )
        => new CarFleetSolution().CarFleetPairsSortTogether( target, position, speed );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 12, new int[] { 10, 8, 0, 5, 3 }, new int[] { 2, 4, 1, 1, 3 } ).Returns( 3 );
            yield return new TestCaseData( 10, new int[] { 3 }, new int[] { 3 } ).Returns( 1 );
            yield return new TestCaseData( 100, new int[] { 0, 2, 4 }, new int[] { 4, 2, 1 } ).Returns( 1 );
            yield return new TestCaseData( 10, new int[] { 0, 4, 2 }, new int[] { 2, 1, 3 } ).Returns( 1 );
        }
    }
}
