#include <vector>
#include <unordered_set>
#include <map>

using namespace std;

/*
    Determine if a 9x9 Sudoku board is valid (no repeats)

    Boolean matrices to store seen values. Check rows, cols, 3x3 sub-boxes

    Time: O(cnt^2)
    Space: O(cnt^2)
*/

class Solution
{
    // 37 ms, 21 MB
    public:
    static bool isValidSudoku( vector<vector<char>>& board )
    {
        map<pair<int, int>, unordered_set<char>> squares;

        for ( int row = 0; row < board.size(); row++ )
        {
            unordered_set<char> rows;
            unordered_set<char> columns;

            for ( int column = 0; column < board[row].size(); column++ )
            {
                pair<int, int> squaresKey = make_pair( row / 3, column / 3 );

                // Checking rows
                if ( board[row][column] != '.' )
                {
                    if ( rows.find( board[row][column] ) != rows.end() ||
                         squares[squaresKey].find( board[row][column] ) != squares[squaresKey].end() )
                    {
                        return false;
                    }

                    rows.insert( board[row][column] );
                    squares[squaresKey].insert(board[row][column]);
                }

                // Checking columns
                if ( board[column][row] != '.' )
                {
                    if ( columns.find( board[column][row] ) != columns.end() )
                    {
                        return false;
                    }

                    columns.insert( board[column][row] );
                }
            }
        }

        return true;
    }

    // 20 ms; Memory 18.1 MB
    public:
    static bool isValidSudokuNeetCode( vector<vector<char>>& board )
    {
        const int dimention = 9;

        bool row[dimention][dimention] = { false };
        bool col[dimention][dimention] = { false };
        bool sub[dimention][dimention] = { false };

        for ( int rowIndex = 0; rowIndex < dimention; rowIndex++ )
        {
            for ( int columnIndex = 0; columnIndex < dimention; columnIndex++ )
            {
                if ( board[rowIndex][columnIndex] == '.' )
                {
                    continue; // if not number pass
                }

                int idx = board[rowIndex][columnIndex] - '0' - 1; // char to num idx
                int area = ( rowIndex / 3 ) * 3 + ( columnIndex / 3 );

                // if number already exists
                if ( row[rowIndex][idx] || col[columnIndex][idx] || sub[area][idx] )
                {
                    return false;
                }

                row[rowIndex][idx] = true;
                col[columnIndex][idx] = true;
                sub[area][idx] = true;
            }
        }

        return true;
    }
};


int isValidSudoku_main()
{
    vector<vector<vector<char>>> input =
    {
        {
            { '5','3','.', '.','7','.', '.','.','.' },
            { '6','.','.', '1','9','5', '.','.','.' },
            { '.','9','8', '.','.','.', '.','6','.' },

            { '8','.','.', '.','6','.', '.','.','3' },
            { '4','.','.', '8','.','3', '.','.','1' }, // true
            { '7','.','.', '.','2','.', '.','.','6' },

            { '.','6','.', '.','.','.', '2','8','.' },
            { '.','.','.', '4','1','9', '.','.','5' },
            { '.','.','.', '.','8','.', '.','7','9' }
        },
        {
            { '8','3','.', '.','7','.', '.','.','.' },
            { '6','.','.', '1','9','5', '.','.','.' },
            { '.','9','8', '.','.','.', '.','6','.' },

            { '8','.','.', '.','6','.', '.','.','3' },
            { '4','.','.', '8','.','3', '.','.','1' }, // false
            { '7','.','.', '.','2','.', '.','.','6' },

            { '.','6','.', '.','.','.', '2','8','.' },
            { '.','.','.', '4','1','9', '.','.','5' },
            { '.','.','.', '.','8','.', '.','7','9' }
        },
        {
            { '.','.','.', '.','5','.', '.','1','.' },
            { '.','4','.', '3','.','.', '.','.','.' },
            { '.','.','.', '.','.','3', '.','.','1' },

            { '8','.','.', '.','.','.', '.','2','.' },
            { '.','.','2', '.','7','.', '.','.','.' }, // false
            { '.','1','5', '.','.','.', '.','.','.' },

            { '.','.','.', '.','.','2', '.','.','.' },
            { '.','2','.', '9','.','.', '.','.','.' },
            { '.','.','4', '.','.','.', '.','.','.' }
        },
        {
            { '.','.','.', '.','.','.', '5','.','.' },
            { '.','.','.', '.','.','.', '.','.','.' },
            { '.','.','.', '.','.','.', '.','.','.' },

            { '9','3','.', '.','2','.', '4','.','.' },
            { '.','.','7', '.','.','.', '3','.','.' }, // false
            { '.','.','.', '.','.','.', '.','.','.' },

            { '.','.','.', '3','4','.', '.','.','.' },
            { '.','.','.', '.','.','3', '.','.','.' },
            { '.','.','.', '.','.','5', '2','.','.' }
        }
    };

    for ( int i = 0; i < input.size(); i++ )
    {
        bool result = Solution::isValidSudoku( input[i] );

        printf( "%s\r\n", result ? "True" : "False" );
    }

    return 0;
}
