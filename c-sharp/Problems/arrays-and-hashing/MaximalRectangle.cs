/**
 * 85
 * Maximal Rectangle
 **
 * Given a rows x cols binary matrix filled with 0's and 1's,
 * find the largest rectangle containing only 1's and return its area.
 *
 * Example 1:
 *   Input:
 *     matrix = [["1","0","1","0","0"],
 *               ["1","0","1","1","1"],
 *               ["1","1","1","1","1"],
 *               ["1","0","0","1","0"]]
 *   Output: 6
 *   Explanation: The maximal rectangle is shown in the above picture.
 *
 * Example 2:
 *   Input: matrix = [["0"]]
 *   Output: 0
 *
 * Example 3:
 *   Input: matrix = [["1"]]
 *   Output: 1
 *
 * Constraints:
 *   • rows == matrix.length
 *   • cols == matrix[i].length
 *   • 1 <= row, cols <= 200
 *   • matrix[i][j] is '0' or '1'.
 **
 * https://leetcode.com/problems/maximal-rectangle/
***/

using System;

namespace Problems;

public class MaximalRectangleSolution
{
    public int MaximalRectangle( char[][] matrix )
    {
        int maxRectangle = 0;

        for ( int i = 0; i < matrix.Length; i++ )
        {
            for ( int j = 0; j < matrix[0].Length; j++ )
            {
                if ( i - 1 >= 0 )
                {
                    matrix[i][j] = (char)( matrix[i][j] == '0' ? '0' : matrix[i - 1][j] + 1 );
                }

                int minWidth = matrix[i][j] - '0';

                for ( int k = j; k >= 0 && matrix[i][k] != '0'; k-- )
                {
                    minWidth = Math.Min( minWidth, matrix[i][k] - '0' );
                    maxRectangle = Math.Max( maxRectangle, minWidth * ( j - k + 1 ) );
                }
            }
        }

        return maxRectangle;
    }
}
