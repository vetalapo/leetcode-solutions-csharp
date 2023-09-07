/*
 * 704
 * Binary Search
 * 
 * Given an array of integers nums which is sorted in ascending order,
 * and an integer target, write a function to search target in nums.
 * If target exists, then return its index. Otherwise, return -1.
 * 
 * You must write an algorithm with O(log n) runtime complexity.
 * 
 * https://leetcode.com/problems/binary-search/
 */

namespace Problems;

public class BinarySearchSolution
{
    public int Search( int[] nums, int target )
    {
        int left = 0;
        int right = nums.Length - 1;

        while ( left <= right )
        {
            int middle = left + ( ( right - left ) / 2 ); // ( left + right ) / 2; can overflow if int.MaxValue

            if ( nums[middle] == target )
            {
                return middle;
            }
            else if ( nums[middle] > target )
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return -1;
    }
}
