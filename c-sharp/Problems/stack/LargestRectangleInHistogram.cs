/**
 * 84
 * Largest Rectangle in Histogram
 **
 * Given an array of integers heights representing the histogram's bar height where the width of each bar is 1, return the area of the largest rectangle in the histogram.
 *
 * Example 1:
 *   Input: heights = [2,1,5,6,2,3]
 *   Output: 10
 *   Explanation:
 *     The above is a histogram where width of each bar is 1.
 *     The largest rectangle is shown in the red area, which has an area = 10 units.
 *
 * Example 2:
 *   Input: heights = [2,4]
 *   Output: 4
 *
 * Constraints:
 *   • 1 <= heights.length <= 105
 *   • 0 <= heights[i] <= 104
 **
 * https://leetcode.com/problems/largest-rectangle-in-histogram/
***/

namespace Problems;

public class LargestRectangleInHistogram
{
    public int LargestRectangleArea( int[] heights )
    {
        int largest = 0;
        Stack<(int Index, int Val)> stack = [];

        for ( int i = 0; i <= heights.Length; i++ )
        {
            int num = i >= heights.Length ? 0 : heights[i];
            int minStackNumIndex = i;

            while ( stack.TryPeek( out (int Index, int Val) topStack ) && topStack.Val > num )
            {
                largest = Math.Max( largest, topStack.Val * ( i - topStack.Index ) );
                minStackNumIndex = topStack.Index;

                stack.Pop();
            }

            stack.Push( (Index: minStackNumIndex, Val: num) );
        }

        return largest;
    }

    public int LargestRectangleExplicit( int[] heights )
    {
        int maxArea = 0;
        Stack<(int inx, int val)> stack = new();

        for ( int i = 0; i < heights.Length; i++ )
        {
            int startIndex = i;

            while ( stack.Count > 0 && stack.Peek().val > heights[i] )
            {
                (int inx, int val) previousHeight = stack.Peek();
                int previousHeightArea = previousHeight.val * ( i - previousHeight.inx );
                startIndex = previousHeight.inx;

                maxArea = Math.Max( maxArea, previousHeightArea );

                stack.Pop();
            }

            stack.Push( (inx: startIndex, val: heights[i]) );
        }

        while ( stack.Count > 0 )
        {
            (int inx, int val) height = stack.Pop();
            int heightArea = height.val * ( heights.Length - height.inx );

            maxArea = Math.Max( maxArea, heightArea );
        }

        return maxArea;
    }
}
