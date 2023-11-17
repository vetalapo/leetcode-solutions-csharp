#include <vector>
#include <iostream>
#include <algorithm>
#include <unordered_set>

using namespace std;

/*
    Given unsorted array, return length of longest consecutive sequence
    Ex. nums = [100,4,200,1,3,2] -> 4, longest is [1,2,3,4]

    Store in hash set, only check for longer seq if it's the beginning

    Time: O(n)
    Space: O(n)
*/
class Solution
{
    // Runtime 71 ms, Memory 34.3 MB
    public:
    static int longestConsecutive( vector<int>& nums )
    {
        if ( nums.empty() )
        {
            return 0;
        }

        sort( nums.begin(), nums.end() );

        vector<int> results;
        int result = 0;

        for ( int i = 1; i < nums.size(); i++ )
        {
            if ( nums[i] == nums[i - 1] )
            {
                continue;
            }

            int difference = nums[i] - nums[i - 1];

            if ( difference  == 1 )
            {
                result++;
            }
            else
            {
                results.push_back( result );
                result = 0;
            }
        }

        results.push_back( result );

        sort( results.begin(), results.end() );

        return results[results.size() - 1] + 1;
    }

    // Runtime 241 ms Memory 45.6 MB
    public:
    static int longestConsecutiveLT( vector<int>& nums )
    {
        unordered_set<int> numSet( nums.begin(), nums.end() );

        int longest = 0;

        for ( auto& n : numSet )
        {
            if ( !numSet.count( n - 1 ) )
            {
                int length = 1;

                while ( numSet.count( n + length ) )
                {
                    length++;
                }

                longest = max( longest, length );
            }
        }

        return longest;
    }
};

int longest_consecutive_sequencemain()
{
    vector<vector<int>> input =
    {
        { 100, 4, 200, 1, 3, 2 },         // 4
        { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, // 9
        { 1, 2, 0, 1 }                    // 3
    };

    for ( int i = 0; i < input.size(); i++ )
    {
        cout << Solution::longestConsecutiveLT( input[i] ) << "\r\n";
    }

    return 0;
}
