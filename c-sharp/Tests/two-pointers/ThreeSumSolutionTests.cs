using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class ThreeSumSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<IList<int>> ThreeSumTest( int[] nums ) =>
        new ThreeSumSolution().ThreeSum( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { -1, 0, 1, 2, -1, -4 } )
                .Returns( new List<List<int>>() { new() { -1, -1, 2 }, new() { -1, 0, 1 } } );

            yield return new TestCaseData( new int[] { 0, 1, 1 } )
                .Returns( new List<List<int>>() );
            
            yield return new TestCaseData( new int[] { 0, 0, 0 } )
                .Returns( new List<List<int>>() { new() { 0, 0, 0 } } );
            
            yield return new TestCaseData( new int[] { 0, 0, 0, 0 } )
                .Returns( new List<List<int>>() { new() { 0, 0, 0 } } );
        }
    }
}
