#include <string>
#include <vector>
#include <iostream>
#include <stack>

using namespace std;

/*
    Given s w/ '(, ), {, }, [, ]', determine if valid
    Ex. s = "()[]{}" -> true, s = "(]" -> false

    Stack of opens, check for matching closes & validity

    Time: O(n)
    Space: O(n)
*/
class Solution
{
    public:
    static bool isValid( string s )
    {
        stack<char> openParentheses;

        for ( int i = 0; i < s.size(); i++ )
        {
            if ( s[i] == ')' || s[i] == ']' || s[i] == '}' )
            {
                if ( openParentheses.empty() )
                {
                    return false;
                }

                if ( s[i] == ')' && openParentheses.top() != '(' )
                {
                    return false;
                }

                if ( s[i] == ']' && openParentheses.top() != '[' )
                {
                    return false;
                }

                if ( s[i] == '}' && openParentheses.top() != '{' )
                {
                    false;
                }

                openParentheses.pop();
            }
            else
            {
                openParentheses.push( s[i] );
            }
        }

        if ( !openParentheses.empty() )
        {
            false;
        }

        return true;
    }
};

int valid_parentheses_main()
{
    vector<string> input =
    {
        "()",     // true
        "()[]{}", // true
        "(]"      // false
    };

    for ( int i = 0; i < input.size(); i++ )
    {
        cout << ( Solution::isValid( input[i] ) ? "True" : "False" ) << endl;
    }

    return 0;
}