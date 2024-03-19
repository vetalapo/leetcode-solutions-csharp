/**
 * 22
 * Generate Parentheses
 **
 * Given n pairs of parentheses,
 * write a function to generate all combinations of well-formed parentheses.
 *
 * Example 1:
 *   Input: n = 3
 *   Output: ["((()))","(()())","(())()","()(())","()()()"]
 * 
 * Example 2:
 *   Input: n = 1
 *   Output: ["()"]
 * 
 * Constraints: 1 <= n <= 8
 **
 * https://leetcode.com/problems/generate-parentheses/
***/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems;

public class GenerateParenthesesSolution
{
    public IList<string> GenerateParenthesis( int n )
    {
        List<string> result = [];
        Stack<char> stack = [];

        void backtrack( int openP, int closedP )
        {
            if ( n == closedP && openP == closedP )
            {
                result.Add( string.Join( "", stack.ToArray().Reverse() ) );

                return;
            }

            if ( openP < n )
            {
                stack.Push( '(' );

                backtrack( openP + 1, closedP );

                stack.Pop();
            }

            if ( closedP < openP )
            {
                stack.Push( ')' );

                backtrack( openP, closedP + 1 );

                stack.Pop();
            }
        }

        backtrack( 0, 0 );

        return result;
    }
}
