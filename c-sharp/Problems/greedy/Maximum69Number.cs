/**
 * 1323
 * Maximum 69 Number
 **
 * You are given a positive integer num consisting only of digits 6 and 9.
 * Return the maximum number you can get by changing at most one digit
 * (6 becomes 9, and 9 becomes 6).
 *
 * Example 1:
 *   Input: num = 9669
 *   Output: 9969
 *   Explanation:
 *     - Changing the first digit results in 6669.
 *     - Changing the second digit results in 9969.
 *     - Changing the third digit results in 9699.
 *     - Changing the fourth digit results in 9666.
 *     The maximum number is 9969.
 *
 * Example 2:
 *   Input: num = 9996
 *   Output: 9999
 *   Explanation: Changing the last digit 6 to 9 results in the maximum number.
 *
 * Example 3:
 *   Input: num = 9999
 *   Output: 9999
 *   Explanation: It is better not to apply any change.
 *
 * Constraints:
 * 1 <= num <= 10^4
 * num consists of only 6 and 9 digits.
 *
 * Hint 1:
 *   Convert the number in an array of its digits.
 *
 * Hint 2:
 *   Brute force on every digit to get the maximum number.
 **
 * https://leetcode.com/problems/maximum-69-number/
***/

using System;

namespace Problems;

public class Maximum69NumberSolution
{
    public int Maximum69Number( int num )
    {
        int firstSix = -1;
        int remainder = num;

        for ( int i = 0; remainder > 0; i++ )
        {
            if ( remainder % 10 == 6 )
            {
                firstSix = i;
            }

            remainder /= 10;
        }

        return num + 3 * (int)Math.Pow( 10, firstSix );
    }
}
