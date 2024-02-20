/**
 * 739
 * Daily Temperatures
 **
 * Given an array of integers temperatures represents the daily temperatures,
 * return an array answer such that answer[i]
 * is the number of days you have to wait after the ith day to get a warmer temperature.
 * If there is no future day for which this is possible, keep answer[i] == 0 instead.
 * 
 * Example 1:
 *   Input: temperatures = [73,74,75,71,69,72,76,73]
 *   Output: [1,1,4,2,1,1,0,0]
 * 
 * Example 2:
 *   Input: temperatures = [30,40,50,60]
 *   Output: [1,1,1,0]
 * 
 * Example 3:
 *   Input: temperatures = [30,60,90]
 *   Output: [1,1,0]
 *
 * Constraints: 
 *   • 1 <= temperatures.length <= 105
 *   • 30 <= temperatures[i] <= 100
 *
 * Hint 1:
 *   If the temperature is say, 70 today,
 *   then in the future a warmer temperature must be either 71, 72, 73, ..., 99, or 100.
 *   We could remember when all of them occur next.
 **
 * https://leetcode.com/problems/daily-temperatures/
***/

namespace Problems;

public class DailyTemperaturesSolution
{
    public int[] DailyTemperatures( int[] temperatures )
    {
        int[] result = new int[temperatures.Length];
        Stack<(int Index, int Value)> stack = [];

        for ( int i = 0; i < temperatures.Length; i++ )
        {
            int currTemp = temperatures[i];

            while ( stack.TryPeek( out (int Index, int Value) topStack ) && currTemp > topStack.Value )
            {
                result[stack.Pop().Index] = i - topStack.Index;
            }

            stack.Push( (i, currTemp) );
        }

        return result;
    }
}
