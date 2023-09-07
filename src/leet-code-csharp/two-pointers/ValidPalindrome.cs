/*
 * 125 
 * Valid Palindrome
 * 
 * A phrase is a palindrome if,
 * after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
 * it reads the same forward and backward. Alphanumeric characters include letters and numbers.
 * 
 * Given a string s, return true if it is a palindrome, or false otherwise.
 * 
 * https://leetcode.com/problems/valid-palindrome/
 */

namespace leet_code_csharp.two_pointers;

public class ValidPalindrome
{
    public bool IsPalindrome( string s )
    {
        int start = 0;
        int end = s.Length - 1;

        while ( start < end )
        {
            char a = char.ToLower( s[start] );
            char z = char.ToLower( s[end] );

            if ( !this.IsLetterOrDigit( a ) )
            {
                start++;
                continue;
            }

            if ( !this.IsLetterOrDigit( z ) )
            {
                end--;
                continue;
            }

            if ( a != z )
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    private bool IsLetterOrDigit( char input )
    {
        return ( input >= '0' && input <= '9' ) ||
               ( input >= 'A' && input <= 'Z' ) ||
               ( input >= 'a' && input <= 'z' );
    }
}
