/**
 * 1512
 * Number of Good Pairs
 **
 * Given an array of integers nums, return the number of good pairs.
 * A pair (i, j) is called good if nums[i] == nums[j] and i < j.
 *
 * Example 1:
 *   Input: nums = [1,2,3,1,1,3]
 *   Output: 4
 *   Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
 *
 * Example 2: 
 *   Input: nums = [1,1,1,1]
 *   Output: 6
 *   Explanation: Each pair in the array are good.
 *
 * Example 3:
 *   Input: nums = [1,2,3]
 *   Output: 0
 **
 * https://leetcode.com/problems/number-of-good-pairs/
 **
**/

using System.Collections.Generic;

namespace Problems;

public class NumberOfGoodPairs
{
    public int NumIdenticalPairs( int[] nums )
    {
        Dictionary<int, int> countMap = new();
        int sum = 0;

        foreach ( int num in nums )
        {
            if ( countMap.ContainsKey( num ) )
            {
                sum += countMap[num]++;
            }
            else
            {
                countMap.Add( num, 1 );
            }
        }

        return sum;
    }
}
