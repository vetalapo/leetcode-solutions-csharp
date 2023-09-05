namespace leet_code_csharp.stack;

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
