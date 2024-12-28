/**
 * 76
 * Minimum Window Substring
 **
 * Given two strings s and t of lengths m and n respectively,
 * return the minimum window substring of s such that
 * every character in t (including duplicates) is included in the window.
 * If there is no such substring, return the empty string "".
 *
 * The testcases will be generated such that the answer is unique.
 *
 * Example 1:
 *   Input: s = "ADOBECODEBANC", t = "ABC"
 *   Output: "BANC"
 *   Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
 *
 * Example 2:
 *   Input: s = "a", t = "a"
 *   Output: "a"
 *   Explanation: The entire string s is the minimum window.
 *
 * Example 3:
 *   Input: s = "a", t = "aa"
 *   Output: ""
 *   Explanation:
 *     Both 'a's from t must be included in the window.
 *     Since the largest window of s only has one 'a', return empty string.
 *
 * Constraints:
 *   • m == s.length
 *   • n == t.length
 *   • 1 <= m, n <= 10^5
 *   • s and t consist of uppercase and lowercase English letters.
 *
 * Follow up:
 *   Could you find an algorithm that runs in O(m + n) time?
 *
 * Hint 1:
 *   Use two pointers to create a window of letters in s, which would have all the characters from t.
 *
 * Hint 2:
 *   Expand the right pointer until all the characters of t are covered.
 *
 * Hint 3:
 *   Once all the characters are covered,
 *   move the left pointer and ensure that
 *   all the characters are still covered to minimize the subarray size.
 *
 * Hint 4:
 *   Continue expanding the right and left pointers until you reach the end of s.
 **
 * https://leetcode.com/problems/minimum-window-substring/
***/

using System.Collections.Generic;

namespace Problems;

public class MinimumWindowSubstring
{
    public string MinWindow( string s, string t )
    {
        Dictionary<char, int> tCount = [];
        Dictionary<char, int> window = [];

        for ( int i = 0; i < t.Length; i++ )
        {
            if ( !tCount.ContainsKey( t[i] ) )
            {
                tCount.Add( t[i], 0 );
            }

            tCount[t[i]]++;
        }

        string result = string.Empty;
        int minCount = int.MaxValue;

        int need = tCount.Count;
        int have = 0;

        int left = 0;

        for ( int right = 0; right < s.Length; right++ )
        {
            char currentLetter = s[right];

            if ( !window.ContainsKey( currentLetter ) )
            {
                window.Add( currentLetter, 0 );
            }

            window[currentLetter]++;

            if ( tCount.ContainsKey( currentLetter ) && window[currentLetter] == tCount[currentLetter] )
            {
                have++;
            }

            while ( have == need )
            {
                // Update result
                int windowSize = right - left + 1;

                if ( windowSize < minCount )
                {
                    result = s.Substring( left, windowSize );
                    minCount = windowSize;
                }

                // Dealing with left
                window[s[left]]--;

                if ( tCount.ContainsKey( s[left] ) && window[s[left]] < tCount[s[left]] )
                {
                    have--;
                }

                left++;
            }
        }

        return result;
    }

    public string MinWindowAlt( string s, string t )
    {
        Dictionary<char, int> sCount = [];
        Dictionary<char, int> tCount = [];

        // Counting keys in t
        for ( int i = 0; i < t.Length; i++ )
        {
            if ( !tCount.ContainsKey( t[i] ) )
            {
                tCount.Add( t[i], 0 );
                sCount.Add( t[i], 0 );
            }

            tCount[t[i]]++;
        }

        string result = string.Empty;
        int minLength = int.MaxValue;

        int need = tCount.Count;
        int have = 0;

        // Walking window
        int left = 0;

        for ( int right = 0; right < s.Length; right++ )
        {
            // Increasing window right till any t char is reached
            while ( !tCount.ContainsKey( s[right] ) || tCount[s[right]] <= 0 )
            {
                if ( right >= s.Length - 1 )
                {
                    return result;
                }

                right++;
            }

            sCount[s[right]]++;

            if ( tCount[s[right]] == sCount[s[right]] )
            {
                have++;
            }

            // Dealing with left
            while ( left < right &&
                ( !tCount.ContainsKey( s[left] ) || sCount[s[left]] > tCount[s[left]] ) )
            {
                if ( !tCount.ContainsKey( s[left] ) )
                {
                    left++;
                }
                else if ( sCount[s[left]] > tCount[s[left]] )
                {
                    sCount[s[left]]--;

                    if ( tCount.ContainsKey( s[left] ) && sCount[s[left]] < tCount[s[left]] )
                    {
                        have--;
                    }

                    left++;
                }
            }

            // Check if we have a match
            while ( have == need )
            {
                int currentMatchLength = right - left + 1;

                if ( currentMatchLength < minLength )
                {
                    minLength = currentMatchLength;
                    result = s.Substring( left, currentMatchLength );
                }

                sCount[s[left]]--;

                if ( tCount.ContainsKey( s[left] ) && sCount[s[left]] < tCount[s[left]] )
                {
                    have--;
                }

                left++;
            }
        }

        return result;
    }
}
