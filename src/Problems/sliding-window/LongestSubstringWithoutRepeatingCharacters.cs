/**
* 3
* Longest Substring Without Repeating Characters
**
* Given a string s, find the length of the longest substring without repeating characters.
* 
* s consists of English letters, digits, symbols and spaces.
* 
* https://leetcode.com/problems/longest-substring-without-repeating-characters/
*/

namespace Problems;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring( string s )
    {
        int maxCount = 0;

        Queue<char> chars = new();

        foreach ( char c in s )
        {
            while ( chars.Contains( c ) )
            {
                chars.Dequeue();
            }

            chars.Enqueue( c );

            maxCount = Math.Max( maxCount, chars.Count );
        }

        return maxCount;
    }

    public int LengthOfLongestSubstringPointers( string s )
    {
        int maxLength = 0;

        int left = 0;
        HashSet<char> charSet = new();

        for ( int right = 0; right < s.Length; right++ )
        {
            while ( charSet.Contains( s[right] ) )
            {
                charSet.Remove( s[left] );
                left++;
            }

            charSet.Add( s[right] );

            maxLength = Math.Max ( maxLength, right - left + 1 );
        }

        return maxLength;
    }
}
