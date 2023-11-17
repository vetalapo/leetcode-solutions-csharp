/**
 * 74
 * Search a 2D Matrix
 **
 * You are given an m x n integer matrix matrix with the following two properties:
 *   Each row is sorted in non-decreasing order.
 *   The first integer of each row is greater than the last integer of the previous row.
 *   
 * Given an integer target, return true if target is in matrix or false otherwise.
 * 
 * You must write a solution in O(log(m * n)) time complexity.
 * 
 * https://leetcode.com/problems/search-a-2d-matrix/
 */

namespace Problems;

public class SearchA2DMatrix
{
    public bool SearchMatrix( int[][] matrix, int target )
    {
        int top = 0;
        int bottom = matrix.Length - 1;

        while ( top <= bottom )
        {
            int verticalMidPoint = ( top + bottom ) / 2;
            int left = 0;
            int right = matrix[verticalMidPoint].Length - 1;

            if ( matrix[verticalMidPoint][left] == target || matrix[verticalMidPoint][right] == target )
            {
                return true;
            }

            if ( matrix[verticalMidPoint][left] > target )
            {
                bottom = verticalMidPoint - 1;
                continue;
            }

            if ( matrix[verticalMidPoint][right] < target )
            {
                top = verticalMidPoint + 1;
                continue;
            }

            while ( left <= right )
            {
                int midPointIndex = left + ( ( right - left ) / 2 );

                if ( matrix[verticalMidPoint][midPointIndex] == target )
                {
                    return true;
                }
                else if ( matrix[verticalMidPoint][midPointIndex] > target )
                {
                    right = midPointIndex - 1;
                }
                else
                {
                    left = midPointIndex + 1;
                }
            }

            break;
        }

        return false;
    }
}
