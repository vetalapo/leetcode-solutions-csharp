/**
 * 239
 * Sliding Window Maximum
 ** 
 * You are given an array of integers nums,
 * there is a sliding window of size k
 * which is moving from the very left of the array to the very right.
 * You can only see the k numbers in the window.
 * Each time the sliding window moves right by one position.
 *
 * Return the max sliding window.
 *
 * Example 1:
 *   Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
 *   Output: [3,3,5,5,6,7]
 *   Explanation: 
 *     Window position                Max
 *     ---------------               -----
 *     [1  3  -1] -3  5  3  6  7       3
 *      1 [3  -1  -3] 5  3  6  7       3
 *      1  3 [-1  -3  5] 3  6  7       5
 *      1  3  -1 [-3  5  3] 6  7       5
 *      1  3  -1  -3 [5  3  6] 7       6
 *      1  3  -1  -3  5 [3  6  7]      7
 * 
 * Example 2:
 *   Input: nums = [1], k = 1
 *   Output: [1]
 *
 * Constraints:
 *   • 1 <= nums.length <= 10^5
 *   • -10^4 <= nums[i] <= 10^4
 *   • 1 <= k <= nums.length
 *
 * Hint 1:
 *   How about using a data structure such as deque (double-ended queue)?
 *
 * Hint 2:
 *   The queue size need not be the same as the window’s size.
 *
 * Hint 3:
 *   Remove redundant elements and the queue should store only elements that need to be considered.
 **
 * https://leetcode.com/problems/sliding-window-maximum/
***/

using System.Collections.Generic;

namespace Problems;

public class SlidingWindowMaximum
{
    public int[] MaxSlidingWindow( int[] nums, int k )
    {
        List<int> result = [];
        LinkedList<int> queue = [];

        int left = 0;
        int right = 0;

        while ( right < nums.Length )
        {
            // Removing smaller values from right, making sure we have max on the right
            while ( queue.Count > 0 && nums[queue.Last.Value] < nums[right] )
            {
                queue.RemoveLast();
            }

            queue.AddLast( right );

            // Removing left value from the window
            if ( left > queue.First.Value )
            {
                queue.RemoveFirst();
            }

            if ( right + 1 >= k )
            {
                result.Add( nums[queue.First.Value] );
                left++;
            }

            right++;
        }

        return [.. result];
    }
}
