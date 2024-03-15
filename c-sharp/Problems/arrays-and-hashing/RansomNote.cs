/**
 * 383
 * Ransom Note
 **
 * Given two strings ransomNote and magazine,
 * return true if ransomNote can be constructed by using the letters from magazine
 * and false otherwise.
 *
 * Each letter in magazine can only be used once in ransomNote.
 *
 * Example 1:
 *   Input: ransomNote = "a", magazine = "b"
 *   Output: false
 *
 * Example 2:
 *   Input: ransomNote = "aa", magazine = "ab"
 *   Output: false
 *
 * Example 3:
 *   Input: ransomNote = "aa", magazine = "aab"
 *   Output: true
 *
 * Constraints:
 *   • 1 <= ransomNote.length, magazine.length <= 105
 *   • ransomNote and magazine consist of lowercase English letters.
 **
 * https://leetcode.com/problems/ransom-note/
***/

namespace Problems;

public class RansomNote
{
    public bool CanConstruct( string ransomNote, string magazine )
    {
        Dictionary<char, ulong> magazineMap = new();

        foreach( char c in magazine )
        {
            if ( !magazineMap.ContainsKey( c ))
            {
                magazineMap[c] = 0;
            }

            magazineMap[c]++;
        }

        foreach ( char c in ransomNote )
        {
            if ( !magazineMap.ContainsKey( c ) || magazineMap[c] <= 0 )
            {
                return false;
            }

            magazineMap[c]--;
        }

        return true;
    }
}
