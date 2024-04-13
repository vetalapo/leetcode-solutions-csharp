/**
 * 402
 * Remove K Digits
 **
 * Given string num representing a non-negative integer num,
 * and an integer k,
 * return the smallest possible integer after removing k digits from num.
 *
 * Example 1:
 *   Input: num = "1432219", k = 3
 *   Output: "1219"
 *   Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.
 *
 * Example 2:
 *   Input: num = "10200", k = 1
 *   Output: "200"
 *   Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.
 *
 * Example 3:
 *   Input: num = "10", k = 2
 *   Output: "0"
 *   Explanation: Remove all the digits from the number and it is left with nothing which is 0.
 *
 * Constraints:
 *   • 1 <= k <= num.length <= 10^5
 *   • num consists of only digits.
 *   • num does not have any leading zeros except for the zero itself.
 **
 * https://leetcode.com/problems/remove-k-digits/
***/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems;

public class RemoveKDigitsSolution
{
    public string RemoveKDigits( string num, int k )
    {
        Stack<char> stack = [];

        foreach ( char c in num )
        {
            while ( stack.TryPeek( out char stackValue ) && k > 0 && stackValue > c )
            {
                stack.Pop();
                k--;
            }

            stack.Push( c );
        }

        while ( k > 0 )
        {
            stack.Pop();
            k--;
        }

        string result = String.Join( "", stack.ToArray().Reverse() );

        int left = 0;

        while ( left < result.Length && result[left] == '0' )
        {
            left++;
        }

        result = result[left..];

        if ( result == string.Empty )
        {
            return "0";
        }

        return result;
    }
}
