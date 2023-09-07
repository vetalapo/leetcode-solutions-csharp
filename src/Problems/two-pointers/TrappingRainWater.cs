/**
 * 42
 * Trapping Rain Water
 **
 * Given n non-negative integers representing an elevation map where the width of each bar is 1,
 * compute how much water it can trap after raining.
 * 
 * https://leetcode.com/problems/trapping-rain-water/
 */

namespace Problems;

public class TrappingRainWater
{
    public int Trap( int[] height )
    {
        int left = 0;
        int right = height.Length - 1;

        int maxLeft = height[left];
        int maxRight = height[right];

        int result = 0;

        while ( left < right )
        {
            if ( maxLeft < maxRight )
            {
                left++;
                maxLeft = Math.Max( maxLeft, height[left] );
                result += maxLeft - height[left];
            }
            else
            {
                right--;
                maxRight = Math.Max( maxRight, height[right] );
                result += maxRight - height[right];
            }
        }

        return result;
    }
}
