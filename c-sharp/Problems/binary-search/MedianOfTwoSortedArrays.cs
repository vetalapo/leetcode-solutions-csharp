/**
 * 4
 * Median of Two Sorted Arrays
 **
 * Given two sorted arrays nums1 and nums2 of size m and n respectively,
 * return the median of the two sorted arrays.
 *
 * The overall run time complexity should be O(log (m+n)). 
 *
 * Example 1:
 *   Input: nums1 = [1,3], nums2 = [2]
 *   Output: 2.00000
 *   Explanation: merged array = [1,2,3] and median is 2.
 *
 * Example 2:
 *   Input: nums1 = [1,2], nums2 = [3,4]
 *   Output: 2.50000
 *   Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
 *
 * Constraints:
 *   • nums1.length == m
 *   • nums2.length == n
 *   • 0 <= m <= 1000
 *   • 0 <= n <= 1000
 *   • 1 <= m + n <= 2000
 *   • -10^6 <= nums1[i], nums2[i] <= 10^6
 **
 * https://leetcode.com/problems/median-of-two-sorted-arrays/
***/

using System;

namespace Problems;

public class MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays( int[] nums1, int[] nums2 )
    {
        // In case if one of the arrays empty
        if ( nums1.Length == 0 || nums2.Length == 0 )
        {
            int[] array = nums1.Length == 0 ? nums2 : nums1;
            int middle = ( array.Length - 1 ) / 2;

            if ( array.Length % 2 == 0 )
            {
                return (double)( array[middle] + array[middle + 1] ) / 2;
            }

            return array[middle];
        }

        int total = nums1.Length + nums2.Length;
        int half = total / 2;

        // Preferring smaller array to be first so binary search operates on smaller set
        if ( nums1.Length > nums2.Length )
        {
            return FindMedianSortedArrays( nums2, nums1 );
        }

        int left = 0;
        int right = nums1.Length - 1;

        while ( true )
        {
            int aMiddleIndex = left + ( ( right - left ) / 2 );
            int bPartitionSize = half - aMiddleIndex - 2;

            double aLeft = aMiddleIndex >= 0 ? nums1[aMiddleIndex] : double.NegativeInfinity;
            double aRight = aMiddleIndex + 1 < nums1.Length ? nums1[aMiddleIndex + 1] : double.PositiveInfinity;

            double bLeft = bPartitionSize >= 0 ? nums2[bPartitionSize] : double.NegativeInfinity;
            double bRight = bPartitionSize + 1 < nums2.Length ? nums2[bPartitionSize + 1] : double.PositiveInfinity;

            // Partition is correct
            if ( aLeft <= bRight && bLeft <= aRight )
            {
                // Even
                if ( total % 2 == 0 )
                {
                    return ( Math.Max( aLeft, bLeft ) + Math.Min( aRight, bRight ) ) / 2;
                }

                // Odd
                return Math.Min( aRight, bRight );
            }
            else if ( aLeft < bRight )
            {
                left += 1;
            }
            else
            {
                right -= 1;
            }
        }
    }
}
