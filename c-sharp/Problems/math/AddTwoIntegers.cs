/**
 * 2235
 * Add Two Integers
 **
 * Given two integers num1 and num2,
 * return the sum of the two integers.
 *
 * Example 1:
 *   Input: num1 = 12, num2 = 5
 *   Output: 17
 *   Explanation: num1 is 12, num2 is 5, and their sum is 12 + 5 = 17, so 17 is returned.
 *
 * Example 2:
 *   Input: num1 = -10, num2 = 4
 *   Output: -6
 *   Explanation: num1 + num2 = -6, so -6 is returned.
 *
 * Constraints:
 *   • -100 <= num1, num2 <= 100
 **
 * https://leetcode.com/problems/add-two-integers/
***/

namespace Problems;

public class AddTwoIntegers
{
    public int Sum( int num1, int num2 )
    {
        return num1 + num2;
    }

    public int SumBitManipulation( int num1, int num2 )
    {
        // Iterate till there is no carry
        while( num2 != 0 )
        {
            // Carry now contains common set bits of num1 and num2
            int carry = num1 & num2; // Marking every location where the addition has a carry

            // Sum of bits of num1 and num2 where at least one of the bits is not set
            num1 ^= num2; // Sum without carries

            // Carry is shifted by one so that adding it to num1 gives the required sum
            num2 = carry << 1; // Shift the carry left one column
        }

        return num1;
    }
}
