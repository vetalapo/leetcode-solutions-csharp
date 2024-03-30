/**
 * 992
 * Subarrays with K Different Integers
 **
 * Given an integer array nums and an integer k, return the number of good subarrays of nums.
 * A good array is an array where the number of different integers in that array is exactly k.
 * For example, [1,2,3,1,2] has 3 different integers: 1, 2, and 3.
 * A subarray is a contiguous part of an array.
 *
 * Example 1:
 *   Input: nums = [1,2,1,2,3], k = 2
 *   Output: 7
 *   Explanation:
 *     Subarrays formed with exactly 2 different integers:
 *     [1,2], [2,1], [1,2], [2,3], [1,2,1], [2,1,2], [1,2,1,2]
 * 
 * Example 2:
 *   Input: nums = [1,2,1,3,4], k = 3
 *   Output: 3
 *   Explanation:
 *     Subarrays formed with exactly 3 different integers:
 *     [1,2,1,3], [2,1,3], [1,3,4].
 *
 * Constraints:
 *   • 1 <= nums.length <= 2 * 10^4
 *   • 1 <= nums[i], k <= nums.length
 **
 * https://leetcode.com/problems/subarrays-with-k-different-integers/
***/

using System.Collections.Generic;

namespace Problems;

public class SubarraysWithKDifferentIntegers
{
    public int SubarraysWithKDistinct( int[] nums, int k )
    {
        int result = 0;

        Dictionary<int, int> freqMap = [];
        int leftNear = 0;
        int leftFar = 0;

        for ( int right = 0; right < nums.Length; right++ )
        {
            if ( freqMap.ContainsKey( nums[right] ) )
            {
                freqMap[nums[right]]++;
            }
            else
            {
                freqMap.Add( nums[right], 1 );
            }

            while ( freqMap.Count > k )
            {
                freqMap[nums[leftNear]]--;

                if ( freqMap[nums[leftNear]] <= 0 )
                {
                    freqMap.Remove( nums[leftNear] );
                }

                leftNear++;
                leftFar = leftNear;
            }

            while ( freqMap[nums[leftNear]] > 1 )
            {
                freqMap[nums[leftNear]]--;
                leftNear++;
            }

            if ( freqMap.Count == k )
            {
                result += leftNear - leftFar + 1;
            }
        }

        return result;
    }
}
