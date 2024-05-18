/**
 * 205
 * Isomorphic Strings
 **
 * Given two strings s and t, determine if they are isomorphic.
 * Two strings s and t are isomorphic if the characters in s can be replaced to get t.
 *
 * All occurrences of a character must be replaced with another character
 * while preserving the order of characters.
 * No two characters may map to the same character,
 * but a character may map to itself.
 *
 * Example 1:
 *   Input: s = "egg", t = "add"
 *   Output: true
 *
 * Example 2:
 *   Input: s = "foo", t = "bar"
 *   Output: false
 *
 * Example 3:
 *   Input: s = "paper", t = "title"
 *   Output: true
 *
 * Constraints:
 *   • 1 <= s.length <= 5 * 10^4
 *   • t.length == s.length
 *   • s and t consist of any valid ascii character.
 **
 * https://leetcode.com/problems/isomorphic-strings/
***/

using System.Collections.Generic;

namespace Problems;

public class IsomorphicStrings
{
    public bool IsIsomorphic( string s, string t )
    {
        Dictionary<char, char> mapST = [];
        Dictionary<char, char> mapTS = [];

        for ( int i = 0; i < s.Length; i++ )
        {
            char c1 = s[i];
            char c2 = t[i];

            if ( ( mapST.TryGetValue( c1, out char c1Value ) && c1Value != c2 ) ||
                 ( mapTS.TryGetValue( c2, out char c2Value ) && c2Value != c1 ) )
            {
                return false;
            }

            mapST[c1] = c2;
            mapTS[c2] = c1;
        }

        return true;
    }
}
