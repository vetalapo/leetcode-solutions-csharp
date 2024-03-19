/**
 * 525
 * Contiguous Array
 **
 * Given a binary array nums,
 * return the maximum length of a contiguous subarray with an equal number of 0 and 1.
 *
 * Example 1:
 *   Input: nums = [0,1]
 *   Output: 2
 *   Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
 *
 * Example 2:
 *   Input: nums = [0,1,0]
 *   Output: 2
 *   Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
 *
 * Constraints:
 *   • 1 <= nums.length <= 10^5
 *   • nums[i] is either 0 or 1.
 **
 * https://leetcode.com/problems/contiguous-array/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class ContiguousArray
{
    public int FindMaxLength( int[] nums )
    {
        int zeros = 0;
        int ones = 0;
        int result = 0;

        Dictionary<int, int> diffIndex = [];

        for ( int i = 0; i < nums.Length; i++ )
        {
            int n = nums[i];

            if ( n == 0 )
            {
                zeros++;
            }
            else
            {
                ones++;
            }

            if ( !diffIndex.ContainsKey( ones - zeros ) )
            {
                diffIndex[ones - zeros] = i;
            }

            if ( ones == zeros )
            {
                result = ones + zeros;
            }
            else
            {
                result = Math.Max( result, i - diffIndex[ones - zeros] );
            }
        }

        return result;
    }
}
