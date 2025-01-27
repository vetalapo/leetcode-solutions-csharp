/**
 * 2652
 * Sum Multiples
 **
 * Given a positive integer n,
 * find the sum of all integers in the range [1, n] inclusive
 * that are divisible by 3, 5, or 7.
 *
 * Return an integer denoting the sum of all numbers in the given range satisfying the constraint.
 *
 * Example 1:
 *   Input: n = 7
 *   Output: 21
 *   Explanation:
 *     Numbers in the range [1, 7]
 *     that are divisible by 3, 5, or 7 are 3, 5, 6, 7.
 *     The sum of these numbers is 21.
 *
 * Example 2:
 *   Input: n = 10
 *   Output: 40
 *   Explanation:
 *     Numbers in the range [1, 10]
 *     that are divisible by 3, 5, or 7 are 3, 5, 6, 7, 9, 10.
 *     The sum of these numbers is 40.
 *
 * Example 3:
 *   Input: n = 9
 *   Output: 30
 *   Explanation:
 *     Numbers in the range [1, 9]
 *     that are divisible by 3, 5, or 7 are 3, 5, 6, 7, 9.
 *     The sum of these numbers is 30.
 *
 * Constraints:
 *   • 1 <= n <= 10^3
 *
 * Hint 1:
 *   Iterate through the range 1 to n and count numbers divisible by either 3, 5, or 7.
 **
 * https://leetcode.com/problems/sum-multiples/
***/

namespace Problems;

public class SumMultiples
{
    public int SumOfMultiples( int n )
    {
        int gaussFactorSum( int term )
        {
            int factor = n / term;

            return term * factor * ( factor + 1 ) / 2;
        }

        // Intuition:
        // Instead of brute-forcing every number in range
        // Sum all multiples 3, 5, 7, and 3 * 5 * 7 (105)
        // Subtract intersecting multiples 3 x 5 (15); 3 x 7 (21); 5 x 7 (35) 
        return gaussFactorSum( 3 ) +
               gaussFactorSum( 5 ) +
               gaussFactorSum( 7 ) +
               gaussFactorSum( 105 ) -
               gaussFactorSum( 15 ) -
               gaussFactorSum( 21 ) -
               gaussFactorSum( 35 );
    }
}
