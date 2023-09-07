/*
 * 33
 * Search in Rotated Sorted Array
 * 
 * There is an integer array nums sorted in ascending order (with distinct values).
 * 
 * Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length)
 * such that the resulting array is
 * [nums[k], nums[k+1], ..., nums[n-1],
 * nums[0], nums[1], ..., nums[k-1]] (0-indexed).
 * 
 * For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].
 * 
 * Given the array nums after the possible rotation and an integer target,
 * return the index of target if it is in nums, or -1 if it is not in nums.
 * 
 * You must write an algorithm with O(log n) runtime complexity.
 * 
 * 
 * https://leetcode.com/problems/search-in-rotated-sorted-array/
 */

namespace leet_code_csharp.binary_search;

public class SearchInRotatedSortedArray
{
    public int Search( int[] nums, int target )
    {
        int left = 0;
        int right = nums.Length - 1;

        while ( left <= right )
        {
            int middle = ( left + right ) / 2;

            if ( nums[ middle ] == target )
            {
                return middle;
            }
            else if ( nums[left] <= nums[middle] ) // left sorted portion
            {
                if ( target < nums[left] || target > nums[middle] )
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            else
            {
                if ( target > nums[right] || target < nums[middle] )
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
        }

        return -1;
    }
}
