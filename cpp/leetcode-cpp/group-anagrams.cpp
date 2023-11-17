#include <string>
#include <vector>
#include <iostream>
#include <unordered_map>
#include <unordered_set>

using namespace std;

bool isAnagram( string a, string b )
{
    if ( a.size() != b.size() )
    {
        return false;
    }

    unordered_map<char, int> aMap;
    unordered_map<char, int> bMap;

    for ( int i = 0; i < a.size(); i++ )
    {
        aMap[a[i]]++;
        bMap[b[i]]++;
    }

    for ( int i = 0; i < aMap.size(); i++ )
    {
        if ( aMap[i] != bMap[i] )
        {
            return false;
        }
    }

    return true;
}

vector<vector<string>> groupAnagrams( vector<string>& strs )
{
    vector<vector<string>> result;
    unordered_set<string> previousMap;

    for ( int i = 0; i < strs.size(); i++ )
    {
        if ( previousMap.find( strs[i] ) != previousMap.end() )
        {
            continue;
        }

        vector<string> rowResult = { strs[i] };
        previousMap.insert( strs[i] );

        for ( int j = i + 1; j < strs.size(); j++ )
        {
            if ( isAnagram( strs[i], strs[j] ) )
            {
                rowResult.push_back( strs[j] );
                previousMap.insert( strs[j] );
            }
        }

        result.push_back( rowResult );
    }

    return result;
}

//////////////////////////////////////////////////////////////////////////////////////////////

string getKey( string str )
{
    vector<int> count( 26 );

    for ( int j = 0; j < str.size(); j++ )
    {
        count[str[j] - 'a']++;
    }

    string key = "";

    for ( int i = 0; i < 26; i++ )
    {
        key.append( to_string( count[i] + 'a' ) );
    }

    return key;
}

vector<vector<string>> groupAnagramsHash( vector<string>& strs )
{
    unordered_map<string, vector<string>> m;

    for ( int i = 0; i < strs.size(); i++ )
    {
        string key = getKey( strs[i] );
        m[key].push_back( strs[i] );
    }

    vector<vector<string>> result;

    for ( auto it = m.begin(); it != m.end(); it++ )
    {
        result.push_back( it -> second );
    }

    return result;
}

int group_anagrams_main()
{
    vector<vector<string>> anagrams
    {
        { "eat", "tea", "tan", "ate", "nat", "bat" }, // [["bat"],["nat","tan"],["ate","eat","tea"]]
        { "" },                                       // [[""]]
        { "a" }                                       // [["a"]]
    };

    for ( int i = 0; i < anagrams.size(); i++ )
    {
        vector<vector<string>> result = groupAnagramsHash( anagrams[i] );

        cout << "[ ";

        for ( int ii = 0; ii < result.size(); ii++ )
        {
            cout << " [";

            for ( int jj = 0; jj < result[ii].size(); jj++ )
            {
                cout << result[ii][jj] + ", ";
            }

            cout << "],";
        }

        cout << " ]\r\n";
    }

    return 0;
}