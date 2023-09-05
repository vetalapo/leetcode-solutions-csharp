using System.Collections;

using NUnit.Framework;

namespace leet_code_csharp.two_pointers.Tests;

[TestFixture]
public class ThreeSumSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<IList<int>> ThreeSumTest( int[] nums ) => new ThreeSumSolution().ThreeSum( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { -1, 0, 1, 2, -1, -4 } )
                .Returns( new List<List<int>>() { new List<int>() { -1, -1, 2 }, new List<int>() { -1, 0, 1 } } );

            yield return new TestCaseData( new int[] { 0, 1, 1 } ).Returns( new List<List<int>>() );
            yield return new TestCaseData( new int[] { 0, 0, 0 } ).Returns( new List<List<int>>() { new List<int>() { 0, 0, 0 } } );
            yield return new TestCaseData( new int[] { 0, 0, 0, 0 } ).Returns( new List<List<int>>() { new List<int>() { 0, 0, 0 } } );
        }
    }
}
