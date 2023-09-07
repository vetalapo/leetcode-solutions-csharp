using System.Collections;

using NUnit.Framework;

namespace leet_code_csharp.binary_search.Tests;

[TestFixture]
public class SearchA2DMatrixTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool SearchMatrixTest( int[][] matrix, int target ) => new SearchA2DMatrix().SearchMatrix( matrix, target );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new[] { new[] { 1, 3, 5, 7 },
                                                   new[] { 10, 11, 16, 20 },
                                                   new[] { 23, 30, 34, 60 } }, 3 ).Returns( true );

            yield return new TestCaseData( new[] { new[] { 1, 3, 5, 7 },
                                                   new[] { 10, 11, 16, 20 },
                                                   new[] { 23, 30, 34, 60 } }, 13 ).Returns( false );

            yield return new TestCaseData( new[] { new[] { 1 } }, 1 ).Returns( true );
            yield return new TestCaseData( new[] { new[] { 1 } }, 0 ).Returns( false );
            yield return new TestCaseData( new[] { new[] { 1 }, new int[] { 3 } }, 2 ).Returns( false );
        }
    }
}