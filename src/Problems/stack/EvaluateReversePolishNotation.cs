/*
 * 150
 * Evaluate Reverse Polish Notation
 * 
 * You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.
 * Evaluate the expression. Return an integer that represents the value of the expression.
 * 
 * Note that:
 *   The valid operators are '+', '-', '*', and '/'.
 *   Each operand may be an integer or another expression.
 *   The division between two integers always truncates toward zero.
 *   There will not be any division by zero.
 *   The input represents a valid arithmetic expression in a reverse polish notation.
 *   The answer and all the intermediate calculations can be represented in a 32-bit integer.
 * 
 * https://leetcode.com/problems/evaluate-reverse-polish-notation/
 */

namespace Problems;

public class EvaluateReversePolishNotation
{
    public int EvalRPN( string[] tokens )
    {
        Stack<int> stack = new();

        foreach ( string token in tokens )
        {
            bool isNumber = int.TryParse( token, out int number );

            if ( isNumber )
            {
                stack.Push( number );
            }
            else
            {
                stack.Push( Evaluate( stack.Pop(), stack.Pop(), token ) );
            }
        }

        return stack.Pop();
    }

    private int Evaluate( int b, int a, string token )
    {
        return token switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
            _ => throw new NotSupportedException()
        };
    }
}
