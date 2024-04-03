using System.Collections;

using NUnit.Framework;

using Problems;

public class WordSearchTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool ExistTest( char[][] board, string word )
        => new WordSearch().Exist( board, word );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new char[][] { ['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E'] }, "ABCCED" )
                .Returns( true );

            yield return new TestCaseData( new char[][] { ['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E'] }, "SEE" )
                .Returns( true );

            yield return new TestCaseData( new char[][] { ['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E'] }, "ABCB" )
                .Returns( false );
        }
    }
}
