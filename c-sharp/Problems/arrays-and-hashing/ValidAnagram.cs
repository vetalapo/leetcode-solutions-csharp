/**
 * 242
 * Valid Anagram
 **
 * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
 * typically using all the original letters exactly once.
 *
 * Example 1:
 *   Input: s = "anagram", t = "nagaram"
 *   Output: true
 *
 * Example 2:
 *   Input: s = "rat", t = "car"
 *   Output: false
 *
 * Constraints:
 *   • 1 <= s.length, t.length <= 5 * 10^4
 *   • s and t consist of lowercase English letters.
 *
 * Follow up:
 *   What if the inputs contain Unicode characters?
 *   How would you adapt your solution to such a case?
 **
 * https://leetcode.com/problems/valid-anagram/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class ValidAnagram
{
    public bool IsAnagram( string s, string t )
    {
        if ( s.Length != t.Length )
        {
            return false;
        }

        if ( s == t )
        {
            return true;
        }

        Dictionary<char, int> sCounts = [];
        Dictionary<char, int> tCounts = [];

        for ( int i = 0; i < s.Length; i++ )
        {
            sCounts[s[i]] = 1 + ( sCounts.TryGetValue( s[i], out int sValue ) ? sValue : 0 );
            tCounts[t[i]] = 1 + ( tCounts.TryGetValue( t[i], out int tValue ) ? tValue : 0 );
        }

        foreach ( (char sKey, int sValue) in sCounts )
        {
            if ( !tCounts.TryGetValue( sKey, out int value ) || value != sValue )
            {
                return false;
            }
        }

        return true;
    }

    public bool IsAnagramBySorting( string s, string t )
    {
        if ( s.Length != t.Length )
        {
            return false;
        }

        if ( s == t )
        {
            return true;
        }

        char[] sCharacters = [.. s];
        Array.Sort( sCharacters );

        char[] tCharacters = [.. t];
        Array.Sort( tCharacters );

        return new string( sCharacters ) == new string( tCharacters );
    }
}
