/**
 * 1
 * Two Sum
 **
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 * 
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * You can return the answer in any order.
 * 
 * https://leetcode.com/problems/two-sum/
 */

namespace Problems;

public class TwoSumSolution
{
    public int[] TwoSum( int[] nums, int target )
    {
        Dictionary<int, int> indices = new();

        for ( int i = 0; i < nums.Length; i++ )
        {
            int diff = target - nums[i];

            if ( indices.ContainsKey( diff ) )
            {
                return new int[] { indices[diff], i };
            }

            indices[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
