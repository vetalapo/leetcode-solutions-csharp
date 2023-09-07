/*
 * 36 
 * Valid Sudoku
 * 
 * Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
 *   Each row must contain the digits 1-9 without repetition.
 *   Each column must contain the digits 1-9 without repetition.
 *   Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
 *   
 * Note:
 *   A Sudoku board (partially filled) could be valid but is not necessarily solvable.
 *   Only the filled cells need to be validated according to the mentioned rules.
 *
 * https://leetcode.com/problems/valid-sudoku/
 */

namespace Problems;

public class ValidSudoku
{
    public bool IsValidSudoku( char[][] board )
    {
        Dictionary<(int row, int col), HashSet<char>> squaresSet = new();

        for ( int row = 0; row < board.Length; row++ )
        {
            HashSet<char> rowsSet = new();
            HashSet<char> collSet = new();

            for ( int col = 0; col < board.Length; col++ )
            {
                // Full rows and colums
                char rowValue = board[row][col];
                char colValue = board[col][row];

                // sub boxes
                int subRowIndex = row / 3;
                int subColIndex = col / 3;

                if ( !squaresSet.ContainsKey( (subRowIndex, subColIndex) ) )
                {
                    squaresSet.Add( (subRowIndex, subColIndex), new HashSet<char>() );
                }

                if ( rowValue != '.' )
                {
                    if ( rowsSet.Contains( rowValue ) )
                    {
                        return false;
                    }

                    if ( squaresSet[(subRowIndex, subColIndex)].Contains( rowValue ) )
                    {
                        return false;
                    }

                    rowsSet.Add( rowValue );
                    squaresSet[(subRowIndex, subColIndex)].Add( rowValue );
                }

                if ( colValue != '.' )
                {
                    if ( collSet.Contains( colValue ) )
                    {
                        return false;
                    }

                    collSet.Add( colValue );
                }
            }
        }

        return true;
    }
}
