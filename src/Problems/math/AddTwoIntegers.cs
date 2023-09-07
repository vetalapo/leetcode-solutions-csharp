/*
 * 2235
 * Add Two Integers
 * 
 * Given two integers num1 and num2, return the sum of the two integers.
 * 
 * https://leetcode.com/problems/add-two-integers/
 */

namespace Problems;

public class AddTwoIntegers
{
    public int Sum( int num1, int num2 )
    {
        return num1 + num2;
    }

    public int SumBitManipulation( int num1, int num2 )
    {
        // Itirate till there is no carry
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
