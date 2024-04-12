/**
 * 1637
 * Widest Vertical Area Between Two Points Containing No Points
 **
 * Given n points on a 2D plane where points[i] = [xi, yi],
 * Return the widest vertical area between two points such that no points are inside the area.
 * A vertical area is an area of fixed-width extending infinitely along the y-axis (i.e., infinite height).
 * The widest vertical area is the one with the maximum width.
 * Note that points on the edge of a vertical area are not considered included in the area.
 *
 * Example 1:
 *   Input: points = [[8,7],[9,9],[7,4],[9,7]]
 *   Output: 1
 *   Explanation: Both the red and the blue area are optimal.
 *
 * Example 2:
 *   Input: points = [[3,1],[9,0],[1,0],[1,4],[5,3],[8,8]]
 *   Output: 3
 *
 * Constraints:
 *   • n == points.length
 *   • 2 <= n <= 105
 *   • points[i].length == 2
 *   • 0 <= xi, yi <= 109
 * 
 * Hint 1: Try sorting the points
 * Hint 2: Think is the y-axis of a point relevant
 **
 * https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/
***/

using System;
using System.Linq;

namespace Problems;

public class WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    public int MaxWidthOfVerticalArea( int[][] points )
    {
        int[] orderedPoints = [.. points.Select( x => x[0] ).Order()];

        int maxWidth = 0;

        for ( int i = 1; i < orderedPoints.Length; i++ )
        {
            maxWidth = Math.Max( maxWidth, orderedPoints[i] - orderedPoints[i - 1] );
        }

        return maxWidth;
    }

    public int MaxWidthOfVerticalAreaSortInPlace( int[][] points )
    {
        Array.Sort( points, ( a, b ) => a[0].CompareTo( b[0] ) );

        int maxWidth = 0;

        for ( int i = 1; i < points.Length; i++ )
        {
            maxWidth = Math.Max( maxWidth, points[i][0] - points[i - 1][0] );
        }

        return maxWidth;
    }

    public int MaxWidthOfVerticalAreaExtractAndSortInPlace( int[][] points )
    {
        int[] xPoints = new int[points.Length];

        for ( int i = 0; i < points.Length; i++ )
        {
            xPoints[i] = points[i][0];
        }

        Array.Sort( xPoints );

        int maxWidth = 0;

        for ( int i = 1; i < xPoints.Length; i++ )
        {
            maxWidth = Math.Max( maxWidth, xPoints[i] - xPoints[i - 1] );
        }

        return maxWidth;
    }
}

