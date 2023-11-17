/**
 * 76
 * Minimum Window Substring
 ** 
 * Given two strings s and t of lengths m and n respectively,
 * return the minimum window substring of s 
 * such that every character in t (including duplicates) is included in the window.
 * 
 * If there is no such substring, return the empty string "".
 * 
 * The testcases will be generated such that the answer is unique.
 * 
 * Follow up: Could you find an algorithm that runs in O(m + n) time?
 * 
 * https://leetcode.com/problems/minimum-window-substring/
 */

namespace Problems;

public class MinimumWindowSubstring
{
    public string MinWindow( string s, string t )
    {
        Dictionary<char, int> tCount = new();
        Dictionary<char, int> window = new();

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
        Dictionary<char, int> sCount = new();
        Dictionary<char, int> tCount = new();

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
