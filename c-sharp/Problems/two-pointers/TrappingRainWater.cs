/**
 * 42
 * Trapping Rain Water
 **
 * Given n non-negative integers representing an elevation map where the width of each bar is 1,
 * compute how much water it can trap after raining.
 *
 * Example 1:
 *   Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
 *   Output: 6
 *   Explanation:
 *     The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1].
 *     In this case, 6 units of rain water (blue section) are being trapped.
 *
 * Example 2:
 *   Input: height = [4,2,0,3,2,5]
 *   Output: 9
 *
 * Constraints:
 *   • n == height.length
 *   • 1 <= n <= 2 * 104
 *   • 0 <= height[i] <= 105
 **
 * https://leetcode.com/problems/trapping-rain-water/
***/

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
