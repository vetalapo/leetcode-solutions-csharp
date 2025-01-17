/**
 * 557
 * Reverse Words in a String III
 **
 * Given a string s,
 * reverse the order of characters in each word within a sentence
 * while still preserving whitespace and initial word order.
 *
 * Example 1:
 *   Input: s = "Let's take LeetCode contest"
 *   Output: "s'teL ekat edoCteeL tsetnoc"
 *
 * Example 2:
 *   Input: s = "Mr Ding"
 *   Output: "rM gniD"
 *
 * Constraints:
 *   • 1 <= s.length <= 5 * 10^4
 *   • s contains printable ASCII characters.
 *   • s does not contain any leading or trailing spaces.
 *   • There is at least one word in s.
 *   • All the words in s are separated by a single space.
 **
 * https://leetcode.com/problems/reverse-words-in-a-string-iii/
***/

using System;

namespace Problems;

public class ReverseWordsInAStringIII
{
    public string ReverseWords( string s )
    {
        char[] result = s.ToCharArray();

        int left = 0;
        int right = 1;

        while ( right <= result.Length )
        {
            if ( right == result.Length || result[right] == ' ' )
            {
                Array.Reverse( result, left, right - left );

                left = right + 1;
            }

            right++;
        }

        return new String( result );
    }
}
