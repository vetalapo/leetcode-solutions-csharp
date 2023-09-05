namespace leet_code_csharp.arrays_and_hashing;

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
