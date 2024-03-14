/**
 * 930
 * Binary Subarrays With Sum
 **
 * Given a binary array nums and an integer goal,
 * return the number of non-empty subarrays with a sum goal.
 *
 * A subarray is a contiguous part of the array.
 *
 * Example 1:
 *   Input: nums = [1,0,1,0,1], goal = 2
 *   Output: 4
 *   Explanation:
 *     The 4 subarrays are bolded and underlined below:
 *       [1,0,1,0,1]
 *       [1,0,1,0,1]
 *       [1,0,1,0,1]
 *       [1,0,1,0,1]
 *
 * Example 2:
 *   Input: nums = [0,0,0,0,0], goal = 0
 *   Output: 15
 *
 * Constraints:
 *   • 1 <= nums.length <= 3 * 10^4
 *   • nums[i] is either 0 or 1.
 *   • 0 <= goal <= nums.length
 **
 * https://leetcode.com/problems/binary-subarrays-with-sum/
***/

namespace Problems;

public class BinarySubarraysWithSum
{
    public int NumSubarraysWithSum( int[] nums, int goal )
    {
        int helper( int num )
        {
            if ( num < 0 )
            {
                return 0;
            }

            int result = 0;
            int left = 0;
            int currentTotalSum = 0;

            for ( int right = 0; right < nums.Length; right++ )
            {
                currentTotalSum += nums[right];

                while ( currentTotalSum > num )
                {
                    currentTotalSum -= nums[left];
                    left++;
                }

                result += right - left + 1;
            }

            return result;
        }

        return helper( goal ) - helper( goal - 1 );
    }
}
