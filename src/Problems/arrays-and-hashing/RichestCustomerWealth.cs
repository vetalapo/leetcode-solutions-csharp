/*
 * 1672
 * Richest Customer Wealth
 * 
 * You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.
 * Return the wealth that the richest customer has.
 * 
 * A customer's wealth is the amount of money they have in all their bank accounts.
 * The richest customer is the customer that has the maximum wealth.
 * 
 * https://leetcode.com/problems/richest-customer-wealth/
 */

namespace Problems;

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
