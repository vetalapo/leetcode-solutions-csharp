/**
 * 14
 * Longest Common Prefix
 **
 * Write a function to find the longest common prefix string amongst an array of strings.
 * If there is no common prefix, return an empty string "".
 *
 * Example 1:
 *   Input: strs = ["flower","flow","flight"]
 *   Output: "fl"
 * 
 * Example 2:
 *   Input: strs = ["dog","racecar","car"]
 *   Output: ""
 *   Explanation: There is no common prefix among the input strings.
 *
 * Constraints:
 *   • 1 <= strs.length <= 200
 *   • 0 <= strs[i].length <= 200
 *   • strs[i] consists of only lowercase English letters.
 **
 * https://leetcode.com/problems/longest-common-prefix/
***/

namespace Problems;

public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix( string[] strs )
    {
        int right = 0;
        bool keepLooping = true;

        while ( right < strs[0].Length && keepLooping )
        {
            for ( int i = 1; i < strs.Length; i++ )
            {
                string word = strs[i];

                if ( right >= word.Length || strs[0][right] != word[right] )
                {
                    keepLooping = false;
                    right--;
                    break;
                }
            }

            right++;
        }

        return strs[0][..right];
    }
}
