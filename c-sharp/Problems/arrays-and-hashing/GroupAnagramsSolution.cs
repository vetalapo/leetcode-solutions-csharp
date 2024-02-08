/**
 * 49
 * Group Anagrams
 **
 * Given an array of strings strs, group the anagrams together.
 * You can return the answer in any order.
 *
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
 * typically using all the original letters exactly once.
 *
 * Example 1:
 *   Input: strs = ["eat","tea","tan","ate","nat","bat"]
 *   Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
 *
 * Example 2:
 *   Input: strs = [""]
 *   Output: [[""]]
 *
 * Example 3:
 *   Input: strs = ["a"]
 *   Output: [["a"]]
 *
 * Constraints:
 *   • 1 <= strs.length <= 104
 *   • 0 <= strs[i].length <= 100
 *   • strs[i] consists of lowercase English letters.
 **
 * https://leetcode.com/problems/group-anagrams/
***/

namespace Problems;

public class GroupAnagramsSolution
{
    public IList<IList<string>> GroupAnagrams( string[] strs )
    {
        Dictionary<string, IList<string>> groups = [];

        foreach ( string str in strs )
        {
            string hash = GetAnagramHash( str );

            if ( groups.TryGetValue( hash, out IList<string>? mapList ) )
            {
                mapList.Add( str );
            }
            else
            {
                groups[hash] = new List<string>() { str };
            }
        }

        return groups.Values.ToList();
    }

    private string GetAnagramHash( string str )
    {
        char[] frequencyArr = new char[26];

        foreach ( char c in str )
        {
            frequencyArr[c - 'a']++;
        }

        return new String( frequencyArr );
    }
}
