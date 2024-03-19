/**
 * 239
 * Sliding Window Maximum
 ** 
 * You are given an array of integers nums,
 * there is a sliding window of size k which is moving from the very left of the array to the very right.
 * You can only see the k numbers in the window.
 * Each time the sliding window moves right by one position.
 * 
 * Return the max sliding window.
 * 
 * https://leetcode.com/problems/sliding-window-maximum/
 */

using System.Collections.Generic;

namespace Problems;

public class SlidingWindowMaximum
{
    public int[] MaxSlidingWindow( int[] nums, int k )
    {
        List<int> result = new();
        LinkedList<int> queue = new();

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

        return result.ToArray();
    }
}
