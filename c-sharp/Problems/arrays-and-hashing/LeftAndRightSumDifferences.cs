/**
 * 2574
 * Left and Right Sum Differences
 **
 * Given a 0-indexed integer array nums, find a 0-indexed integer array answer where:
 *   • answer.length == nums.length.
 *   • answer[i] = |leftSum[i] - rightSum[i]|.
 *
 * Where:
 *   • leftSum[i] is the sum of elements to the left of the index i in the array nums.
 *     If there is no such element, leftSum[i] = 0.
 *   • rightSum[i] is the sum of elements to the right of the index i in the array nums.
 *     If there is no such element, rightSum[i] = 0.
 *
 * Return the array answer.
 *
 * Example 1:
 *   Input: nums = [10,4,8,3]
 *   Output: [15,1,11,22]
 *   Explanation: The array leftSum is [0,10,14,22] and the array rightSum is [15,11,3,0].
 *                The array answer is [|0 - 15|,|10 - 11|,|14 - 3|,|22 - 0|] = [15,1,11,22].
 *
 * Example 2:
 *   Input: nums = [1]
 *   Output: [0]
 *   Explanation: The array leftSum is [0] and the array rightSum is [0].
 *                The array answer is [|0 - 0|] = [0].
 *
 * Constraints:
 *   • 1 <= nums.length <= 1000
 *   • 1 <= nums[i] <= 10^5
 *
 * Hint 1: For each index i, maintain two variables leftSum and rightSum.
 *
 * Hint 2:
 *   Iterate on the range j: [0 … i - 1] and
 *   add nums[j] to the leftSum and
 *   similarly iterate on the range j: [i + 1 … nums.length - 1] and
 *   add nums[j] to the rightSum.
 **
 * https://leetcode.com/problems/left-and-right-sum-differences/
***/

using System;

namespace Problems;

public class LeftAndRightSumDifferences
{
    public int[] LeftRightDifference( int[] nums )
    {
        int[] result = new int[nums.Length];

        for ( int i = 1; i < nums.Length; i++ )
        {
            result[i] = result[i - 1] + nums[i - 1];
        }

        int postfix = 0;

        for ( int i = result.Length - 1; i >= 0; i-- )
        {
            result[i] = Math.Abs( result[i] - postfix );
            postfix += nums[i];
        }

        return result;
    }
}
