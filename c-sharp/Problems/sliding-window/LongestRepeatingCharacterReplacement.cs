/**
 * 424
 * Longest Repeating Character Replacement
 ** 
 * You are given a string s and an integer k.
 * You can choose any character of the string and change it to any other uppercase English character.
 * You can perform this operation at most k times.
 * 
 * Return the length of the longest substring containing the same letter you can get after performing the above operations.
 *
 * Example 1: 
 *   Input: s = "ABAB", k = 2
 *   Output: 4
 *   Explanation: Replace the two 'A's with two 'B's or vice versa.
 * 
 * Example 2:
 *   Input: s = "AABABBA", k = 1
 *   Output: 4
 *   Explanation:
 *     Replace the one 'A' in the middle with 'B' and form "AABBBBA".
 *     The substring "BBBB" has the longest repeating letters, which is 4.
 *     There may exists other ways to achieve this answer too.
 *
 * Constraints: 
 *   • 1 <= s.length <= 105
 *   • s consists of only uppercase English letters.
 *   • 0 <= k <= s.length
 **
 * https://leetcode.com/problems/longest-repeating-character-replacement/
***/

namespace Problems;

public class LongestRepeatingCharacterReplacement
{
    public int CharacterReplacement( string s, int k )
    {
        int maxLength = 0;
        
        int[] charCount = new int[26]; // 0 - A; 25 - Z
        int mostFreqLetterCnt = 0;

        int left = 0;

        for ( int right = 0; right < s.Length; right++ )
        {
            charCount[s[right] - 'A']++;

            mostFreqLetterCnt = Math.Max( mostFreqLetterCnt, charCount[s[right] - 'A'] );

            if ( ( right - left + 1 ) - mostFreqLetterCnt > k )
            {
                charCount[s[left] - 'A']--;

                left++;
            }

            maxLength = Math.Max( maxLength, right - left + 1 );
        }

        return maxLength;
    }
}
