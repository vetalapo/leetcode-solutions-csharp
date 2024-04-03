/**
 * 79
 * Word Search
 **
 * Given an m x n grid of characters board and a string word,
 * return true if word exists in the grid.
 *
 * The word can be constructed from letters of sequentially adjacent cells,
 * where adjacent cells are horizontally or vertically neighboring.
 * The same letter cell may not be used more than once.
 *
 * Example 1:
 *   Input:
 *     board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]],
 *     word = "ABCCED"
 *   Output: true
 *
 * Example 2:
 *   Input:
 *     board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]],
 *     word = "SEE"
 *   Output: true
 *
 * Example 3:
 *   Input:
 *     board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]],
 *     word = "ABCB"
 *   Output: false
 *
 * Constraints:
 *   • m == board.length
 *   • n = board[i].length
 *   • 1 <= m, n <= 6
 *   • 1 <= word.length <= 15
 *   • board and word consists of only lowercase and uppercase English letters.
 *
 * Follow up: Could you use search pruning to make your solution faster with a larger board?
 **
 * https://leetcode.com/problems/word-search/
***/

namespace Problems;

public class WordSearch
{
    public bool Exist( char[][] board, string word )
    {
        int rows = board.Length;
        int cols = board[0].Length;

        if ( rows * cols < word.Length )
        {
            return false;
        }

        bool[,] visited = new bool[rows, cols];

        bool dfs( int row, int col, int i )
        {
            if ( i == word.Length )
            {
                return true;
            }

            if ( row < 0 || col < 0 ||
                 row >= rows || col >= cols ||
                 word[i] != board[row][col] ||
                 visited[row, col] )
            {
                return false;
            }

            visited[row, col] = true;

            bool result =
                   dfs( row + 1, col, i + 1 ) ||
                   dfs( row - 1, col, i + 1 ) ||
                   dfs( row, col + 1, i + 1 ) ||
                   dfs( row, col - 1, i + 1 );

            visited[row, col] = false;

            return result;
        }

        for ( int r = 0; r < rows; r++ )
        {
            for ( int c = 0; c < cols; c++ )
            {
                if ( dfs( r, c, 0 ) )
                {
                    return true;
                }
            }
        }

        return false;
    }
}
