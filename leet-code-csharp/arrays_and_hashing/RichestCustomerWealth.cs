namespace leet_code_csharp.arrays_and_hashing;

public class RichestCustomerWealth
{
    public int MaximumWealth( int[][] accounts )
    {
        int wealth = 0;

        for ( int i = 0; i < accounts.Length; i++ )
        {
            int sum = 0;

            for ( int j = 0; j < accounts[i].Length; j++ )
            {
                sum += accounts[i][j];
            }

            wealth = Math.Max( wealth, sum );
        }

        return wealth;
    }
}
