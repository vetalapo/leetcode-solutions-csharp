/**
 * 3264
 * Final Array State After K Multiplication Operations I
 **
 * You are given an integer array nums, an integer k, and an integer multiplier.
 *
 * You need to perform k operations on nums. In each operation:
 *   • Find the minimum value x in nums.
 *     If there are multiple occurrences of the minimum value,
 *     select the one that appears first.
 *   • Replace the selected minimum value x with x * multiplier.
 *
 * Return an integer array denoting the final state of nums after performing all k operations.
 *
 * Example 1:
 *   Input: nums = [2,1,3,5,6], k = 5, multiplier = 2
 *   Output: [8,4,6,5,6]
 *   Explanation:
 *      Operation           Result
 *      After operation 1:  [2, 2, 3, 5, 6]
 *      After operation 2:  [4, 2, 3, 5, 6]
 *      After operation 3:  [4, 4, 3, 5, 6]
 *      After operation 4:  [4, 4, 6, 5, 6]
 *      After operation 5:  [8, 4, 6, 5, 6]
 *
 * Example 2:
 *   Input: nums = [1,2], k = 3, multiplier = 4
 *   Output: [16,8]
 *   Explanation:
 *     Operation          Result
 *     After operation 1  [4, 2]
 *     After operation 2  [4, 8]
 *     After operation 3  [16, 8]
 *
 * Constraints:
 *   • 1 <= nums.length <= 100
 *   • 1 <= nums[i] <= 100
 *   • 1 <= k <= 10
 *   • 1 <= multiplier <= 5
 *
 * Hint 1:
 *   Maintain sorted pairs (nums[index], index) in a priority queue.
 *
 * Hint 2:
 *   Simulate the operation k times.
 **
 * https://leetcode.com/problems/final-array-state-after-k-multiplication-operations-i/
***/

using System.Collections.Generic;

namespace Problems;

public class FinalArrayStateAfterKMultiplicationOperationsI
{
    public int[] GetFinalState( int[] nums, int k, int multiplier )
    {
        PriorityQueue<int, (int priority, int i)> pq = new(
            nums.Length,
            Comparer<(int priority, int index)>.Create( ( a, b ) =>
            {
                if ( a.priority == b.priority )
                {
                    return a.index - b.index;
                }

                return a.priority - b.priority;
            } )
        );

        for ( int i = 0; i < nums.Length; i++ )
        {
            pq.Enqueue( nums[i], (nums[i], i) );
        }

        while ( k > 0 )
        {
            pq.TryDequeue( out int element, out (int val, int index) priority );

            element *= multiplier;

            pq.Enqueue( element, (element, priority.index) );

            k--;
        }

        while ( pq.TryDequeue( out int element, out (int val, int index) priority ) )
        {
            nums[priority.index] = element;
        }

        return nums;
    }

    // On small sets Brute-Force runs faster
    public int[] GetFinalStateBF( int[] nums, int k, int multiplier )
    {
        while ( k > 0 )
        {
            int minIndex = 0;

            for ( int i = 0; i < nums.Length; i++ )
            {
                if ( nums[i] < nums[minIndex] )
                {
                    minIndex = i;
                }
            }

            nums[minIndex] *= multiplier;

            k--;
        }

        return nums;
    }
}
