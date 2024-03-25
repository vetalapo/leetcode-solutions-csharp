/**
 * 442
 * Find All Duplicates in an Array
 **
 * Given an integer array nums of length n where all the integers of nums are in the range [1, n]
 * and each integer appears once or twice, return an array of all the integers that appears twice.
 *
 * You must write an algorithm that runs in O(n) time and uses only constant extra space.
 *
 * Example 1:
 * Input: nums = [4,3,2,7,8,2,3,1]
 * Output: [2,3]
 *
 * Example 2:
 * Input: nums = [1,1,2]
 * Output: [1]
 *
 * Example 3:
 * Input: nums = [1]
 * Output: []
 *
 * Constraints:
 *   • n == nums.length
 *   • 1 <= n <= 105
 *   • 1 <= nums[i] <= n
 *   • Each element in nums appears once or twice.
 **
 * https://leetcode.com/problems/find-all-duplicates-in-an-array/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class FindAllDuplicatesInAnArray
{
    public IList<int> FindDuplicates( int[] nums )
    {
        List<int> result = [];

        foreach ( int num in nums )
        {
            int absNum = Math.Abs( num );

            if ( nums[absNum - 1] < 0 )
            {
                result.Add( absNum );
            }

            nums[absNum - 1] = -nums[absNum - 1];
        }

        return result;
    }

    public IList<int> FindDuplicatesHashSet( int[] nums )
    {
        List<int> result = [];
        HashSet<int> checkSet = [];

        foreach ( int num in nums )
        {
            if ( !checkSet.Add( num ) )
            {
                result.Add( num );
            }
        }

        return result;
    }
}
