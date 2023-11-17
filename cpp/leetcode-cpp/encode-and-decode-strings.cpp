#include <string>
#include <vector>
#include <iostream>

using namespace std;

/*
    Design algorithm to encode/decode: list of strings <-> string

    Encode/decode w/ non-ASCII delimiter: {len of str, "#", str}

    Time: O(n)
    Space: O(1)
*/

class Solution
{
    public:
    /*
     * @param strs: a list of strings
     * @return: encodes a list of strings to a single string.
     */
    static string encode( vector<string>& strs )
    {
        string accumulator;

        for ( int i = 0; i < strs.size(); i++ )
        {
            accumulator += to_string( strs[i].size() ) + "#" + strs[i];
        }

        return accumulator;
    }

    /*
     * @param str: A string
     * @return: dcodes a single string to a list of strings
     */
    static vector<string> decode( string& str )
    {
        vector<string> result;

        int i = 0;
        while ( i < str.size() )
        {
            int j = i;

            while ( str[j] != '#' )
            {
                j++;
            }

            int length = stoi( str.substr( i, j - i ) );
            string locStr = str.substr( j + 1, length );
            
            result.push_back( locStr );

            i = j + 1 + length;
        }

        return result;
    }
};

int encode_and_decode_main()
{
    vector<vector<string>> input =
    {
        { "lint", "code", "love", "you" },
        { "we", "say", ":", "yes" }
    };

    for ( int i = 0; i < input.size(); i++ )
    {
        string encoded = Solution::encode( input[i] );

        cout << encoded << "\r\n";

        vector<string> decoded = Solution::decode( encoded );

        for ( int j = 0; j < decoded.size(); j++ )
        {
            cout << decoded[j] << " ";
        }

        cout << "\r\n";
    }

    return 0;
}
