namespace leet_code_csharp.arrays_and_hashing;

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
