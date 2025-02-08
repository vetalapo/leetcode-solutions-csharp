/**
 * 1351
 * Count Negative Numbers in a Sorted Matrix
 **
 * Given a m x n matrix grid
 * which is sorted in non-increasing order
 * both row-wise and column-wise,
 * return the number of negative numbers in grid.
 *
 * Example 1:
 *   Input: grid = [[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]
 *   Output: 8
 *   Explanation: There are 8 negatives number in the matrix.
 *
 * Example 2:
 *   Input: grid = [[3,2],[1,0]]
 *   Output: 0
 *
 * Constraints:
 *   • m == grid.length
 *   • n == grid[i].length
 *   • 1 <= m, n <= 100
 *   • -100 <= grid[i][j] <= 100
 *
 * Follow up: Could you find an O(n + m) solution?
 *
 * Hint 1:
 *   Use binary search for optimization or simply brute force.
 **
 * https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
***/

namespace Problems;

public class CountNegativeNumbersInASortedMatrix
{
    public int CountNegatives( int[][] grid )
    {
        int negativeNumbersCount = 0;

        for ( int row = 0; row < grid.Length; row++ )
        {
            int col = grid[row].Length - 1;

            while ( col >= 0 && grid[row][col] < 0 )
            {
                negativeNumbersCount++;
                col--;
            }
        }

        return negativeNumbersCount;
    }
}
