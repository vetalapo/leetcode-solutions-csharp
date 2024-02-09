/**
 * 347
 * Top K Frequent Elements
 **
 * Given an integer array nums and an integer k, return the k most frequent elements.
 * You may return the answer in any order.
 * 
 * Example 1:
 *   Input: nums = [1,1,1,2,2,3], k = 2
 *   Output: [1,2]
 * 
 * Example 2:
 *   Input: nums = [1], k = 1
 *   Output: [1]
 *
 * Constraints:
 *   • 1 <= nums.length <= 105
 *   • -104 <= nums[i] <= 104
 *   • k is in the range [1, the number of unique elements in the array].
 *   • It is guaranteed that the answer is unique.
 *  
 * 
 * Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
 ** 
 * https://leetcode.com/problems/top-k-frequent-elements/
***/

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Problems;

public class TopKFrequentElements
{
    public int[] TopKFrequent( int[] nums, int k )
    {
        Dictionary<int, int> frequencyMap = [];

        foreach ( int num in nums )
        {
            ref int valOrNull = ref CollectionsMarshal.GetValueRefOrNullRef( frequencyMap, num );

            if ( Unsafe.IsNullRef( ref valOrNull ) )
            {
                frequencyMap[num] = 1;
            }
            else
            {
                valOrNull++;
            }
        }

        PriorityQueue<int, int> priorityQueue = new( frequencyMap.Count );

        foreach ( (int key, int value) in frequencyMap )
        {
            priorityQueue.Enqueue( key, value * -1 );
        }

        int[] result = new int[k];

        for ( int i = 0; i < k; i++ )
        {
            result[i] = priorityQueue.Dequeue();
        }

        return result;
    }
}
