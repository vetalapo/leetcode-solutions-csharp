/**
 * 20
 * Valid Parentheses
 **
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
 * determine if the input string is valid.
 *
 * An input string is valid if:
 *   • Open brackets must be closed by the same type of brackets.
 *   • Open brackets must be closed in the correct order.
 *   • Every close bracket has a corresponding open bracket of the same type.
 *
 * Example 1:
 *   Input: s = "()"
 *   Output: true
 *
 * Example 2:
 *   Input: s = "()[]{}"
 *   Output: true
 *
 * Example 3:
 *   Input: s = "(]"
 *   Output: false
 *
 * Constraints:
 *   • 1 <= s.length <= 104
 *   • s consists of parentheses only '()[]{}'.
 *
 * Hint 1: Use a stack of characters.
 *
 * Hint 2: When you encounter an opening bracket, push it to the top of the stack.
 *
 * Hint 3:
 *   When you encounter a closing bracket,
 *   check if the top of the stack was the opening for it.
 *   If yes, pop it from the stack. Otherwise, return false
 **
 * https://leetcode.com/problems/valid-parentheses/
***/

using System.Collections.Generic;

namespace Problems;

public class ValidParentheses
{
    private static readonly Dictionary<char, char> _parenthesesPairs = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };

    public bool IsValid( string s )
    {
        Stack<char> parenthesesStack = [];

        foreach ( char c in s )
        {
            if ( _parenthesesPairs.ContainsKey( c ) )
            {
                parenthesesStack.Push( c );
            }
            else if ( !parenthesesStack.TryPop( out char prevBracketPair ) || _parenthesesPairs[prevBracketPair] != c )
            {
                return false;
            }
        }

        return parenthesesStack.Count == 0;
    }
}
