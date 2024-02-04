/**
 * 1281
 * Subtract the Product and Sum of Digits of an Integer
 **
 * Given an integer number n, return the difference between the product of its digits and the sum of its digits.
 *
 * Example 1:
 *   Input: n = 234
 *   Output: 15 
 *   Explanation: 
 *     Product of digits = 2 * 3 * 4 = 24 
 *     Sum of digits = 2 + 3 + 4 = 9 
 *     Result = 24 - 9 = 15
 * 
 * Example 2:
 *   Input: n = 4421
 *   Output: 21
 *   Explanation: 
 *     Product of digits = 4 * 4 * 2 * 1 = 32 
 *     Sum of digits = 4 + 4 + 2 + 1 = 11 
 *     Result = 32 - 11 = 21
 *
 * Constraints: 1 <= n <= 10^5
 * 
 * Hint 1: How to compute all digits of the number ?
 * Hint 2: Use modulus operator (%) to compute the last digit.
 * Hint 3: Generalise modulus operator idea to compute all digits.
 **
 * https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
***/

namespace Problems;

public class SubtractProductAndSumDigitsOfInteger
{
    public int SubtractProductAndSum( int n )
    {
        int product = 1;
        int sum = 0;

        while ( n > 0 )
        {
            int lastDigit = n % 10;

            product *= lastDigit;
            sum += lastDigit;

            n /= 10;
        }

        return product - sum;
    }
}
