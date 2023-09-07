using System.Collections;

using NUnit.Framework;

namespace leet_code_csharp.arrays_and_hashing.Tests;

[TestFixture]
public class RichestCustomerWealthTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int MaximumWealthTest( int[][] accounts ) => new RichestCustomerWealth().MaximumWealth( accounts );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new object[] { new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } } } ).Returns( 6 );
            yield return new TestCaseData( new object[] { new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } } } ).Returns( 10 );
            yield return new TestCaseData( new object[] { new int[][] { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } } } ).Returns( 17 );
        }
    }
}
