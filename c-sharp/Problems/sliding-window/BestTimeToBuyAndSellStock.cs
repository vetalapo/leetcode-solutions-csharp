/**
 * 121
 * Best Time to Buy and Sell Stock
 **
 * You are given an array prices where prices[i] is the price of a given stock on the ith day.
 * 
 * You want to maximize your profit by choosing a single day to buy one stock
 * and choosing a different day in the future to sell that stock.
 * 
 * Return the maximum profit you can achieve from this transaction.
 * If you cannot achieve any profit, return 0.
 * 
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
 */

namespace Problems;

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit( int[] prices )
    {
        int maxProfit = 0;
        int left = 0;
        int right = 1;

        while ( right < prices.Length )
        {
            if ( prices[left] >= prices[right] )
            {
                left = right;
            }
            else
            {
                maxProfit = Math.Max( maxProfit, prices[right] - prices[left] );
            }

            right++;
        }

        return maxProfit;
    }
}
