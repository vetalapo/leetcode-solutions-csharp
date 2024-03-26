/**
 * 41
 * First Missing Positive
 **
 * Given an unsorted integer array nums.
 * Return the smallest positive integer that is not present in nums.
 * You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.
 *
 * Example 1:
 *   Input: nums = [1,2,0]
 *   Output: 3
 *   Explanation: The numbers in the range [1,2] are all in the array.
 *
 * Example 2:
 *   Input: nums = [3,4,-1,1]
 *   Output: 2
 *   Explanation: 1 is in the array but 2 is missing.
 *
 * Example 3:
 *   Input: nums = [7,8,9,11,12]
 *   Output: 1
 *   Explanation: The smallest positive integer 1 is missing.
 *
 * Constraints:
 *   • 1 <= nums.length <= 10^5
 *   • -2^31 <= nums[i] <= 2^31 - 1
 * 
 * Hint 1:
 *   Think about how you would solve the problem in non-constant space.
 *   Can you apply that logic to the existing space?
 * 
 * Hint 2:
 *   We don't care about duplicates or non-positive integers
 * 
 * Hint 3:
 *   Remember that O(2n) = O(n)
 **
 * https://leetcode.com/problems/first-missing-positive/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class FirstMissingPositiveSolution
{
    public int FirstMissingPositive( int[] nums )
    {
        for ( int i = 0; i < nums.Length; i++ )
        {
            if ( nums[i] < 0 )
            {
                nums[i] = 0;
            }
        }

        for ( int i = 0; i < nums.Length; i++ )
        {
            int absNum = Math.Abs( nums[i] );

            if ( 1 <= absNum && absNum <= nums.Length )
            {
                if ( nums[absNum - 1] > 0 )
                {
                    nums[absNum - 1] *= -1;
                }
                else if ( nums[absNum - 1] == 0 )
                {
                    nums[absNum - 1] = -1 * ( nums.Length + 1 );
                }
            }
        }

        for ( int i = 1; i <= nums.Length + 1; i++ )
        {
            if ( nums[i - 1] >= 0 )
            {
                return i;
            }
        }

        return nums.Length + 1;
    }

    public int FirstMissingPositiveHashSet( int[] nums )
    {
        HashSet<int> numsSet = new( nums );

        for ( int i = 1; i <= nums.Length + 1; i++ )
        {
            if ( !numsSet.Contains( i ) )
            {
                return i;
            }
        }

        return nums.Length + 1;
    }
}
