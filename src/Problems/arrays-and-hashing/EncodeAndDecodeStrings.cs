/*
 * 271
 * Encode and Decode Strings
 * 
 * Design an algorithm to encode a list of strings to a string.
 * The encoded string is then sent over the network and is decoded back to the original list of strings.
 * 
 * Please implement encode and decode
 *
 *  https://leetcode.com/problems/encode-and-decode-strings/
 */

namespace Problems;

public class EncodeAndDecodeStrings
{
    public string Encode( IList<string> strs ) => string.Concat( strs.SelectMany( s => $"{s.Length}#{s}" ) );

    public IList<string> Decode( string str )
    {
        List<string> result = new();

        int i = 0;

        while ( i < str.Length )
        {
            int j = i;

            while ( str[j] != '#' )
            {
                j++;
            }

            int.TryParse( str.Substring( i, j - i ), out int currentWordLength );
            
            j++;

            result.Add( str.Substring( j, currentWordLength ) );

            i = j + currentWordLength;
        }

        return result;
    }
}
