﻿/**
 * 1684
 * Count the Number of Consistent Strings
 **
 * You are given a string allowed consisting of distinct characters and an array of strings words.
 * A string is consistent if all characters in the string appear in the string allowed.
 *
 * Return the number of consistent strings in the array words.
 *
 * Example 1:
 *   Input: allowed = "ab", words = ["ad","bd","aaab","baa","badab"]
 *   Output: 2
 *   Explanation: Strings "aaab" and "baa" are consistent since they only contain characters 'a' and 'b'.
 *
 * Example 2:
 *   Input: allowed = "abc", words = ["a","b","c","ab","ac","bc","abc"]
 *   Output: 7
 *   Explanation: All strings are consistent.
 *
 * Example 3:
 *   Input: allowed = "cad", words = ["cc","acd","b","ba","bac","bad","ac","d"]
 *   Output: 4
 *   Explanation: Strings "cc", "acd", "ac", and "d" are consistent.
 *
 * Constraints:
 *   • 1 <= words.length <= 10^4
 *   • 1 <= allowed.length <= 26
 *   • 1 <= words[i].length <= 10
 *   • The characters in allowed are distinct.
 *   • words[i] and allowed contain only lowercase English letters.
 *
 * Hint 1:
 *   A string is incorrect if it contains a character that is not allowed
 *
 * Hint 2:
 *   Constraints are small enough for brute force
 **
 * https://leetcode.com/problems/count-the-number-of-consistent-strings/
***/

namespace Problems;

public class CountTheNumberOfConsistentStrings
{
    public int CountConsistentStrings( string allowed, string[] words )
    {
        int consistentCount = words.Length;

        foreach ( string word in words )
        {
            foreach ( char letter in word )
            {
                if ( !allowed.Contains( letter ) )
                {
                    consistentCount--;

                    break;
                }
            }
        }

        return consistentCount;
    }
}
