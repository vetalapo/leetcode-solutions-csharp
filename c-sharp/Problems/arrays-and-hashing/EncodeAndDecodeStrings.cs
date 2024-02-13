/**
 * 271
 * Encode and Decode Strings
 **
 * Design an algorithm to encode a list of strings to a single string.
 * The encoded string is then decoded back to the original list of strings.
 *
 * Please implement encode and decode.
 *
 * Example 1:
 *   Input: ["neet","code","love","you"]
 *   Output:["neet","code","love","you"]
 *
 * Example 2:
 *   Input: ["we","say",":","yes"]
 *   Output: ["we","say",":","yes"]
 *
 * Constraints:
 *   • 0 <= strs.length < 100
 *   • 0 <= strs[i].length < 200
 *   • strs[i] contains only UTF-8 characters.
 **
 *  https://leetcode.com/problems/encode-and-decode-strings/
***/

namespace Problems;

public class EncodeAndDecodeStrings
{
    public string Encode( IList<string> strs ) => string.Concat( strs.SelectMany( s => $"{s.Length}#{s}" ) );

    public IList<string> Decode( string str )
    {
        List<string> result = [];

        int i = 0;

        while ( i < str.Length )
        {
            int j = i;

            while ( str[j] != '#' )
            {
                j++;
            }

            int.TryParse( str.AsSpan( i, j - i ), out int wordLength );
            
            j++;

            result.Add( str.Substring( j, wordLength ) );

            i = j + wordLength;
        }

        return result;
    }
}
