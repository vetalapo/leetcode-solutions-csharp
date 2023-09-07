/* 
 * 347
 * Top K Frequent Elements
 * 
 * Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
 * 
 * https://leetcode.com/problems/top-k-frequent-elements/
 */

namespace Problems;

public class TopKFrequentElements
{
    public int[] TopKFrequent( int[] nums, int k )
    {
        Dictionary<int, int> frequencyMap = new();

        foreach ( int n in nums )
        {
            if ( !frequencyMap.ContainsKey( n ) )
            {
                frequencyMap[n] = 0;
            }

            frequencyMap[n]++;
        }

        PriorityQueue<int, int> priorityQueue = new();

        foreach ( int mapKey in frequencyMap.Keys )
        {
            priorityQueue.Enqueue( mapKey, frequencyMap[mapKey] );

            if ( priorityQueue.Count > k )
            {
                priorityQueue.Dequeue();
            }
        }

        int[] result = new int[k];

        while ( priorityQueue.Count > 0 )
        {
            result[--k] = priorityQueue.Dequeue();
        }

        return result;
    }
}
