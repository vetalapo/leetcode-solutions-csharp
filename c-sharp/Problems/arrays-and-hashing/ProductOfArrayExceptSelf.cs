/**
 * 238
 * Product of Array Except Self
 **
 * Given an integer array nums,
 * return an array answer such that
 * answer[i] is equal to the product of all the elements of nums except nums[i].
 *
 * The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 * You must write an algorithm that runs in O(n) time and without using the division operation.
 *
 * Example 1:
 *   Input: nums = [1,2,3,4]
 *   Output: [24,12,8,6]
 *
 * Example 2:
 *   Input: nums = [-1,1,0,-3,3]
 *   Output: [0,0,9,0,0]
 *
 * Constraints:
 *   • 2 <= nums.length <= 10^5
 *   • -30 <= nums[i] <= 30
 *   • The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 *
 * Follow up:
 *   Can you solve the problem in O(1) extra space complexity?
 *   (The output array does not count as extra space for space complexity analysis.)
 **
 * https://leetcode.com/problems/product-of-array-except-self/
***/

using System;

namespace Problems;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf( int[] nums )
    {
        int[] result = new int[nums.Length];

        result[0] = 1;

        for ( int i = 0; i < nums.Length - 1; i++ )
        {
            result[i + 1] = nums[i] * result[i];
        }

        int postfix = 1;

        for ( int i = nums.Length - 1; i >= 0; i-- )
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }

    public int[] ProductExceptSelfCombination( int[] nums )
    {
        int size = nums.Length;

        int[] result = new int[size];
        Array.Fill( result, 1 );

        int prefix = 1;
        int postfix = 1;

        for ( int i = 0; i < size; i++ )
        {
            result[i] *= prefix;
            prefix *= nums[i];

            result[size - i - 1] *= postfix;
            postfix *= nums[size - i - 1];
        }

        return result;
    }
}
