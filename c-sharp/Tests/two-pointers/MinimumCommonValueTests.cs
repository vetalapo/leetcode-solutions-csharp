using System.Collections;

using NUnit.Framework;

using Problems;

public class MinimumCommonValueTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int GetCommonTest( int[] nums1, int[] nums2 ) =>
        new MinimumCommonValue().GetCommon( nums1, nums2 );

    [TestCaseSource( nameof( TestCases ) )]
    public int GetCommonAltTest( int[] nums1, int[] nums2 ) =>
        new MinimumCommonValue().GetCommonAlt( nums1, nums2 );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 1, 2, 3 }, new int[] { 2, 4 } ).Returns( 2 );

            yield return new TestCaseData( new int[] { 1, 2, 3, 6 }, new int[] { 2, 3, 4, 5 } ).Returns( 2 );
        }
    }
}
