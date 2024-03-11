/**
 * 2540
 * Minimum Common Value
 **
 * Given two integer arrays nums1 and nums2,
 * sorted in non-decreasing order,
 * return the minimum integer common to both arrays.
 *
 * If there is no common integer amongst nums1 and nums2, return -1.
 *
 * Note that an integer is said to be common to nums1 and nums2
 * if both arrays have at least one occurrence of that integer.
 *
 * Example 1:
 *   Input: nums1 = [1,2,3], nums2 = [2,4]
 *   Output: 2
 *   Explanation: The smallest element common to both arrays is 2, so we return 2.
 *
 * Example 2:
 *   Input: nums1 = [1,2,3,6], nums2 = [2,3,4,5]
 *   Output: 2
 *   Explanation: There are two common elements in the array 2 and 3 out of which 2 is the smallest, so 2 is returned.
 *
 * Constraints:
 *   • 1 <= nums1.length, nums2.length <= 10^5
 *   • 1 <= nums1[i], nums2[j] <= 10^9
 *   • Both nums1 and nums2 are sorted in non-decreasing order.
 ** 
 * https://leetcode.com/problems/minimum-common-value/
***/

namespace Problems;

public class MinimumCommonValue
{
    public int GetCommon( int[] nums1, int[] nums2 )
    {
        if ( nums1.Length < nums2.Length )
        {
            return GetCommon( nums2, nums1 );
        }

        if ( nums1[^1] < nums2[0] || nums2[^1] < nums1[0] )
        {
            return -1;
        }

        foreach ( int num in nums2 )
        {
            int left = 0;
            int right = nums1.Length - 1;

            while ( left <= right )
            {
                int midIndex = left + ( right - left ) / 2;
                int midValue = nums1[midIndex];

                if ( midValue == num )
                {
                    return num;
                }
                else if ( midValue > num )
                {
                    right = midIndex - 1;
                }
                else
                {
                    left = midIndex + 1;
                }
            }
        }

        return -1;
    }

    public int GetCommonAlt( int[] nums1, int[] nums2 )
    {
        int i = 0;
        int j = 0;

        while ( i < nums1.Length && j < nums2.Length )
        {
            if ( nums1[i] == nums2[j] )
            {
                return nums1[i];
            }
            else if ( nums1[i] > nums2[j] )
            {
                j++;
            }
            else
            {
                i++;
            }
        }

        return -1;
    }
}
