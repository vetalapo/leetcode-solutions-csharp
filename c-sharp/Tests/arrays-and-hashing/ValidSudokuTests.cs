﻿using System.Collections;

using NUnit.Framework;

using Problems;

public class ValidSudokuTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool IsValidSudokuTest( char[][] board ) =>
        new ValidSudoku().IsValidSudoku( board );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [ new char[][]
            {
                ['5','3','.','.','7','.','.','.','.'],
                ['6','.','.','1','9','5','.','.','.'],
                ['.','9','8','.','.','.','.','6','.'],
                ['8','.','.','.','6','.','.','.','3'],
                ['4','.','.','8','.','3','.','.','1'],
                ['7','.','.','.','2','.','.','.','6'],
                ['.','6','.','.','.','.','2','8','.'],
                ['.','.','.','4','1','9','.','.','5'],
                ['.','.','.','.','8','.','.','7','9']
            }] ).Returns( true );

            yield return new TestCaseData( [ new char[][]
            {
                ['8','3','.','.','7','.','.','.','.'],
                ['6','.','.','1','9','5','.','.','.'],
                ['.','9','8','.','.','.','.','6','.'],
                ['8','.','.','.','6','.','.','.','3'],
                ['4','.','.','8','.','3','.','.','1'],
                ['7','.','.','.','2','.','.','.','6'],
                ['.','6','.','.','.','.','2','8','.'],
                ['.','.','.','4','1','9','.','.','5'],
                ['.','.','.','.','8','.','.','7','9']
            }] ).Returns( false );

            yield return new TestCaseData( [ new char[][]
            {
                ['5','3','.','.','7','.','.','.','.'],
                ['6','.','3','1','9','5','.','.','.'],
                ['.','9','8','.','.','.','.','6','.'],
                ['8','.','.','.','6','.','.','.','3'],
                ['4','.','.','8','.','3','.','.','1'],
                ['7','.','.','.','2','.','.','.','6'],
                ['.','6','.','.','.','.','2','8','.'],
                ['.','.','.','4','1','9','.','.','5'],
                ['.','.','.','.','8','.','.','7','9']
            }] ).Returns( false );

            yield return new TestCaseData( [ new char[][]
            {
                ['5','3','.','.','7','.','.','.','.'],
                ['6','.','.','1','9','5','.','.','.'],
                ['.','9','8','.','.','.','.','6','.'],
                ['8','.','.','.','6','.','.','.','3'],
                ['4','.','.','8','.','3','.','.','1'],
                ['7','.','.','.','2','.','.','.','6'],
                ['.','6','.','.','.','.','2','8','.'],
                ['.','.','.','4','1','9','.','.','5'],
                ['.','.','.','.','8','.','5','7','9']
            }] ).Returns( false );
        }
    }
}
