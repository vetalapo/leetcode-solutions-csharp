/**
 * 4
 * Median of Two Sorted Arrays
 **
 * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
 * The overall run time complexity should be O(log (m+n)).
 *
 * https://leetcode.com/problems/median-of-two-sorted-arrays/
 */

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

        // Preffering smaller array to be first so binary search operates on smaller set
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
