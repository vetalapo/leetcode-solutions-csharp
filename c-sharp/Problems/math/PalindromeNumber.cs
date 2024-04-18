/**
 * 9
 * Palindrome Number
 **
 * Given an integer x, return true if x is a palindrome, and false otherwise.
 *
 * Example 1:
 *   Input: x = 121
 *   Output: true
 *   Explanation: 121 reads as 121 from left to right and from right to left.
 *
 * Example 2:
 *   Input: x = -121
 *   Output: false
 *   Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
 *
 * Example 3:
 *   Input: x = 10
 *   Output: false
 *   Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 *
 * Constraints:
 *   -2^31 <= x <= 2^31 - 1
 *
 * Follow up: Could you solve it without converting the integer to a string?
 *
 * Hint 1: Beware of overflow when you reverse the integer.
 **
 * https://leetcode.com/problems/palindrome-number/
***/

namespace Problems;

public class PalindromeNumber
{
    public bool IsPalindrome( int x )
    {
        if ( x < 0 )
        {
            return false;
        }

        if ( x < 10 )
        {
            return true;
        }

        int xCopy = x;
        int xReversed = 0;

        while ( xCopy > 0 )
        {
            xReversed = ( xReversed * 10 ) + ( xCopy % 10 );
            xCopy /= 10;
        }

        return x == xReversed;
    }
}
