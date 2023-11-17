/**
 * 20
 * Valid Parentheses
 **
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 * 
 * An input string is valid if:
 *   1. Open brackets must be closed by the same type of brackets.
 *   2. Open brackets must be closed in the correct order.
 *   3. Every close bracket has a corresponding open bracket of the same type.
 * 
 * https://leetcode.com/problems/valid-parentheses/
 */

namespace Problems;

public class ValidParentheses
{
    public bool IsValid( string s )
    {
        Stack<char> parenthesesStack = new();
        Dictionary<char, char> parenthesesPairs = new()
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' },
        };

        foreach ( char c in s )
        {
            if ( !parenthesesPairs.ContainsKey( c ) )
            {
                parenthesesStack.Push( c );
            }
            else if ( parenthesesStack.Count == 0 || parenthesesPairs[c] != parenthesesStack.Pop() )
            {
                return false;
            }
        }

        return parenthesesStack.Count == 0;
    }
}
