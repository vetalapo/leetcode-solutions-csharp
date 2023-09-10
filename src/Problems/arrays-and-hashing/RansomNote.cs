/**
 * 383
 * Ransom Note
 **
 * Given two strings ransomNote and magazine,
 * return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
 * Each letter in magazine can only be used once in ransomNote.
 * 
 * https://leetcode.com/problems/ransom-note/
 */

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
