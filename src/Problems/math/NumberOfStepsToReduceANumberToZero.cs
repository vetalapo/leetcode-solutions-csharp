/**
 * 1342
 * Number of Steps to Reduce a Number to Zero
 **
 * Given an integer num, return the number of steps to reduce it to zero.
 * In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
 * 
 * https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
 */

namespace Problems;

public class NumberOfStepsToReduceANumberToZero
{
    public int NumberOfSteps( int num )
    {
        byte numberOfSteps = 0;

        while ( num > 0 )
        {
            if ( num % 2 == 0 )
            {
                num /= 2;
            }
            else
            {
                num--;
            }

            numberOfSteps++;
        }

        return numberOfSteps;
    }

    public int NumberOfStepsBitwise( int num )
    {
        byte numberOfSteps = 0;

        while ( num > 0 )
        {
            // Check if even
            if ( ( num & 1 ) != 1 )
            {
                num >>= 1; // Dividing by 2
            }
            else
            {
                num--;
            }

            numberOfSteps++;
        }

        return numberOfSteps;
    }
}
