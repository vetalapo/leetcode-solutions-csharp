/**
 * 28
 * Find the Index of the First Occurrence in a String
 **
 * Given two strings needle and haystack,
 * return the index of the first occurrence of needle in haystack,
 * or -1 if needle is not part of haystack.
 *
 * Example 1:
 *   Input: haystack = "sadbutsad", needle = "sad"
 *   Output: 0
 *   Explanation:
 *     "sad" occurs at index 0 and 6.
 *     The first occurrence is at index 0, so we return 0.
 *
 * Example 2:
 *   Input: haystack = "leetcode", needle = "leeto"
 *   Output: -1
 *   Explanation:
 *     "leeto" did not occur in "leetcode",
 *     so we return -1.
 *
 * Constraints:
 *   • 1 <= haystack.length, needle.length <= 10^4
 *   • haystack and needle consist of only lowercase English characters.
 **
 * https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
***/

namespace Problems;

public class FindTheIndexOfTheFirstOccurrenceInAString
{
    public int StrStr( string haystack, string needle )
    {
        if ( needle.Length > haystack.Length )
        {
            return -1;
        }

        for ( int i = 0; i < haystack.Length; i++ )
        {
            if ( haystack[i] == needle[0] )
            {
                int needleLastIndex = 1;

                while ( needleLastIndex < needle.Length && i + needleLastIndex < haystack.Length )
                {
                    if ( haystack[i + needleLastIndex] != needle[needleLastIndex] )
                    {
                        break;
                    }

                    needleLastIndex++;
                }

                if ( needleLastIndex == needle.Length )
                {
                    return i;
                }
            }
        }

        return -1;
    }
}
