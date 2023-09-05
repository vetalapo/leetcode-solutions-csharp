namespace leet_code_csharp.binary_search;

public class KokoEatingBananas
{
    public int MinEatingSpeed( int[] piles, int h )
    {
        int left = 1;
        int right = piles.Max();
        int k = right;

        while ( left <= right )
        {
            int middleK = left + ( ( right - left ) / 2 );
            long hours = 0;

            foreach ( int pile in piles )
            {
                hours += (int)Math.Ceiling( pile / (decimal)middleK );
            }

            if ( hours <= h )
            {
                k = Math.Min( k, middleK );
                right = middleK - 1;
            }
            else
            {
                left = middleK + 1;
            }
        }

        return k;
    }
}
