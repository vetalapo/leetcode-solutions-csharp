/**
 * 739
 * Daily Temperatures
 **
 * Given an array of integers temperatures represents the daily temperatures,
 * return an array answer such that
 * answer[i] is the number of days you have to wait after the ith day to get a warmer temperature.
 * 
 * If there is no future day for which this is possible, keep answer[i] == 0 instead.
 * 
 * https://leetcode.com/problems/daily-temperatures/
 */

namespace Problems;

public class DailyTemperaturesSolution
{
    public int[] DailyTemperatures( int[] temperatures )
    {
        int[] result = new int[temperatures.Length];
        Stack<int> indxStack = new();

        for ( int i = 0; i < temperatures.Length; i++ )
        {
            while ( indxStack.Count > 0 && temperatures[i] > temperatures[indxStack.Peek()] )
            {
                int prevTempIndex = indxStack.Pop();

                result[prevTempIndex] = i - prevTempIndex;
            }

            indxStack.Push( i );
        }

        return result;
    }
}
