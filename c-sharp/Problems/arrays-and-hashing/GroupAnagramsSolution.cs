/**
 * 49
 * Group Anagrams
 **
 * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
 * 
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
 * typically using all the original letters exactly once. 
 * 
 * https://leetcode.com/problems/group-anagrams/
 */

namespace Problems;

public class GroupAnagramsSolution
{
    public IList<IList<string>> GroupAnagrams( string[] strs )
    {
        Dictionary<string, IList<string>> groups = new();

        foreach ( string str in strs )
        {
            string key = GetHashKey( str );

            if ( !groups.ContainsKey( key ) )
            {
                groups[key] = new List<string>();
            }

            groups[key].Add( str );
        }

        return groups.Values.ToList();
    }

    private string GetHashKey( string str )
    {
        char[] hash = new char[26];

        foreach ( char c in str )
        {
            hash[c - 'a']++;
        }

        return new string( hash );
    }
}
