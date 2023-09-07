/*
 * 128
 * Longest Consecutive Sequence
 * 
 * Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
 * You must write an algorithm that runs in O(n) time.
 * 
 * https://leetcode.com/problems/longest-consecutive-sequence/
 */

namespace Problems;

public class LongestConsecutiveSequence
{
    public int LongestConsecutive( int[] nums )
    {
        HashSet<int> numsSet = new( nums );

        int maxConsecutiveCount = 0;

        foreach ( int n in numsSet )
        {
            if ( numsSet.Contains( n - 1 ) )
            {
                continue;
            }

            int currentConsecutiveCount = 0;

            while ( numsSet.Contains( n + currentConsecutiveCount ) )
            {
                currentConsecutiveCount++;
            }

            maxConsecutiveCount = Math.Max( maxConsecutiveCount, currentConsecutiveCount );
        }

        return maxConsecutiveCount;
    }
}
