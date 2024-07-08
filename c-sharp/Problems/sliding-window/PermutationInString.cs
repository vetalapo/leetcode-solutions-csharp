/**
 * 567
 * Permutation in String
 **
 * Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
 * In other words, return true if one of s1's permutations is the substring of s2.
 *
 * Example 1:
 *   Input: s1 = "ab", s2 = "eidbaooo"
 *   Output: true
 *   Explanation: s2 contains one permutation of s1 ("ba").
 *
 * Example 2:
 *   Input: s1 = "ab", s2 = "eidboaoo"
 *   Output: false
 *
 * Constraints:
 *   • 1 <= s1.length, s2.length <= 10^4
 *   • s1 and s2 consist of lowercase English letters.
 * 
 * Hint 1:
 *   Obviously, brute force will result in TLE. Think of something else.
 * 
 * Hint 2:
 *   How will you check whether one string is a permutation of another string?
 *
 * Hint 3:
 *   One way is to sort the string and then compare.
 *   But, Is there a better way?
 *
 * Hint 4:
 *   If one string is a permutation of another string then they must one common metric.
 *   What is that?
 *
 * Hint 5:
 *   Both strings must have same character frequencies, if one is permutation of another.
 *   Which data structure should be used to store frequencies?
 *
 * Hint 6:
 *   What about hash table? An array of size 26?
 **
 * https://leetcode.com/problems/permutation-in-string/
***/

namespace Problems;

public class PermutationInString
{
    public bool CheckInclusion( string s1, string s2 )
    {
        // s1 must be less or equal s2, otherwise no inclusion
        if ( s1.Length > s2.Length )
        {
            return false;
        }

        // Initial count
        int[] s1Count = new int[26];
        int[] s2PortionCount = new int[26];

        for ( int i = 0; i < s1.Length; i++ )
        {
            s1Count[s1[i] - 'a']++;
            s2PortionCount[s2[i] - 'a']++;
        }

        // Counting mathes on initial values
        int matches = 0;

        for ( int i = 0; i < 26; i++ )
        {
            if ( s1Count[i] == s2PortionCount[i] )
            {
                matches++;
            }
        }

        // Matching the rest of s2
        int left = 0;

        for ( int right = s1.Length; right < s2.Length; right++ )
        {
            if ( matches == 26 )
            {
                return true;
            }

            // Extending window right
            int index = s2[right] - 'a';

            s2PortionCount[index]++;

            if ( s1Count[index] == s2PortionCount[index] )
            {
                matches++;
            }
            else if ( s1Count[index] + 1 == s2PortionCount[index] )
            {
                matches--;
            }

            // Deleting left portion
            index = s2[left] - 'a';

            s2PortionCount[index]--;

            if ( s1Count[index] == s2PortionCount[index] )
            {
                matches++;
            }
            else if ( s1Count[index] - 1 == s2PortionCount[index] )
            {
                matches--;
            }

            left++;
        }

        return matches == 26;
    }
}
