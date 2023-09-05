using System.Collections;

using NUnit.Framework;

namespace leet_code_csharp.arrays_and_hashing.Tests;

[TestFixture]
public class ProductOfArrayExceptSelfTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[] ProductExceptSelfTest( int[] nums ) => new ProductOfArrayExceptSelf().ProductExceptSelf( nums );

    [TestCaseSource( nameof( TestCases ) )]
    public int[] ProductExceptSelfCombinationTest( int[] nums ) => new ProductOfArrayExceptSelf().ProductExceptSelfCombination( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 1, 2, 3, 4 } ).Returns( new int[] { 24, 12, 8, 6 } );
            yield return new TestCaseData( new int[] { -1, 1, 0, -3, 3 } ).Returns( new int[] { 0, 0, 9, 0, 0 } );
        }
    }
}
