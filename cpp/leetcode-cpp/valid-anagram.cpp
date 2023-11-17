#include <iostream>
#include <string>
#include <vector>
#include <unordered_set>
#include <algorithm>
#include <unordered_map>

using namespace std;

// 729 ms to run, 7.4 MB
bool _isAnagram( string s, string t )
{
    if ( s.size() != t.size() )
    {
        return false;
    }

    for ( int i = 0; i < s.size(); i++ )
    {
        int findIndex = t.find( s[i] );

        if ( findIndex == string::npos )
        {
            // not found
            return false;
        }

        t.erase( findIndex, 1 );
    }

    return true;
}

// 16 ms to run, 7.3 MB
bool isAnagramSort( string s, string t )
{
    sort( s.begin(), s.end() );
    sort( t.begin(), t.end() );

    return s == t;
}

// 11 ms, 7.9 MB
bool isAnagramHash( string s, string t )
{
    if ( s.size() != t.size() )
    {
        return false;
    }

    unordered_map<char, int> countSMap;
    unordered_map<char, int> countTMap;

    for ( int i = 0; i < s.size(); i++ )
    {
        countSMap[s[i]]++;
        countTMap[t[i]]++;
    }

    for ( int i = 0; i < countSMap.size(); i++ )
    {
        if ( countSMap[i] != countTMap[i] )
        {
            return false;
        }
    }

    return true;
}

int valid_anagram_main()
{
    vector<vector<string>>inputArray =
    {
        { "anagram", "nagaram" }, // true
        { "rat", "car" }          // false
    };

    for ( int i = 0; i < inputArray.size(); i++ )
    {
        printf( "%s\r\n", isAnagramHash( inputArray[i][0], inputArray[i][1] ) ? "True" : "False" );
    }

    return 0;
}