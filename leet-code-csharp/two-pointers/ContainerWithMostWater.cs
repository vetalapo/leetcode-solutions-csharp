/*
 * 11
 * Container With Most Water
 * 
 * You are given an integer array height of length n.
 * There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
 * Find two lines that together with the x-axis form a container, such that the container contains the most water.
 * 
 * Return the maximum amount of water a container can store.
 * Notice that you may not slant the container.
 * 
 * https://leetcode.com/problems/container-with-most-water/
 */

namespace leet_code_csharp.two_pointers;

public class ContainerWithMostWater
{
    public int MaxArea( int[] height )
    {
        int start = 0;
        int end = height.Length - 1;

        int maxArea = 0;

        while ( start < end )
        {
            int diff = end - start;
            int currentMinheight;

            if ( height[start] > height[end] )
            {
                currentMinheight = height[end];
                end--;
            }
            else
            {
                currentMinheight = height[start];
                start++;
            }

            maxArea = Math.Max( maxArea, diff * currentMinheight );
        }

        return maxArea;
    }
}
