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
 * s consists of only uppercase English letters.
 * 
 * https://leetcode.com/problems/longest-repeating-character-replacement/description/
 */

namespace Problems;

public class LongestRepeatingCharacterReplacement
{
    public int CharacterReplacement( string s, int k )
    {
        int maxLength = 0;
        int left = 0;
        int[] charCount = new int[26]; // 0 - A; 25 - Z

        for ( int right = 0; right < s.Length; right++ )
        {
            charCount[s[right] - 'A']++;

            while ( ( right - left + 1 ) - charCount.Max() > k )
            {
                charCount[s[left] - 'A']--;

                left++;
            }

            maxLength = Math.Max( maxLength, right - left + 1 );
        }

        return maxLength;
    }
}
