/**
 * 3
 * Longest Substring Without Repeating Characters
 **
 * Given a string s, find the length of the longest substring
 * ( A substring is a contiguous non-empty sequence of characters within a string. )
 * without repeating characters.
 *
 * Example 1:
 *   Input: s = "abcabcbb"
 *   Output: 3
 *   Explanation: The answer is "abc", with the length of 3.
 *
 * Example 2:
 *   Input: s = "bbbbb"
 *   Output: 1
 *   Explanation: The answer is "b", with the length of 1.
 *
 * Example 3:
 *   Input: s = "pwwkew"
 *   Output: 3
 *   Explanation:
 *     The answer is "wke", with the length of 3.
 *     Notice that the answer must be a substring,
 *     "pwke" is a subsequence and not a substring.
 *
 * Constraints:
 *   • 0 <= s.length <= 5 * 10^4
 *   • s consists of English letters, digits, symbols and spaces.
 **
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring( string s )
    {
        int maxCount = 0;

        Queue<char> chars = [];

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
        HashSet<char> charSet = [];

        for ( int right = 0; right < s.Length; right++ )
        {
            while ( charSet.Contains( s[right] ) )
            {
                charSet.Remove( s[left] );
                left++;
            }

            charSet.Add( s[right] );

            maxLength = Math.Max( maxLength, right - left + 1 );
        }

        return maxLength;
    }
}
