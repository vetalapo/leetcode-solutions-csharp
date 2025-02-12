﻿/**
 * 1051
 * Height Checker
 **
 * A school is trying to take an annual photo of all the students.
 * The students are asked to stand in a single file line in non-decreasing order by height.
 * Let this ordering be represented by the integer array expected where expected[i]
 * is the expected height of the ith student in line.
 *
 * You are given an integer array heights
 * representing the current order that the students are standing in.
 * Each heights[i] is the height of the ith student in line (0-indexed).
 *
 * Return the number of indices where heights[i] != expected[i].
 *
 * Example 1:
 *   Input: heights = [1,1,4,2,1,3]
 *   Output: 3
 *   Explanation:
 *     heights:  [1,1,4,2,1,3]
 *     expected: [1,1,1,2,3,4]
 *     Indices 2, 4, and 5 do not match.
 *
 * Example 2:
 *   Input: heights = [5,1,2,3,4]
 *   Output: 5
 *   Explanation:
 *     heights:  [5,1,2,3,4]
 *     expected: [1,2,3,4,5]
 *     All indices do not match.
 *
 * Example 3:
 *   Input: heights = [1,2,3,4,5]
 *   Output: 0
 *   Explanation:
 *     heights:  [1,2,3,4,5]
 *     expected: [1,2,3,4,5]
 *     All indices match.
 *
 * Constraints:
 *   • 1 <= heights.length <= 100
 *   • 1 <= heights[i] <= 100
 *
 * Hint 1:
 *   Build the correct order of heights by sorting another array,
 *   then compare the two arrays.
 **
 * https://leetcode.com/problems/height-checker/
***/

namespace Problems;

public class HeightCheckerSolution
{
    public int HeightChecker( int[] heights )
    {
        int[] countMap = new int[101];

        foreach ( int height in heights )
        {
            countMap[height]++;
        }

        int differenceCount = 0;
        int heightsIndex = 0;

        for ( int height = 1; height < countMap.Length; height++ )
        {
            while ( countMap[height] > 0 )
            {
                if ( heights[heightsIndex] != height )
                {
                    differenceCount++;
                }

                heightsIndex++;
                countMap[height]--;
            }
        }

        return differenceCount;
    }
}
