#include <vector>
#include <unordered_map>

using namespace std;

// 409 ms, 10.3 MB
vector<int> twoSum( vector<int>& nums, int target )
{
    for ( int i = 0; i < nums.size(); i++ )
    {
        for ( int j = i + 1; j < nums.size(); j++ )
        {
            if ( nums[i] + nums[j] == target )
            {
                return { i, j };
            }
        }
    }
}

// 8 ms, 11 MB
vector<int> twoSumHash( vector<int>& nums, int target )
{
    unordered_map<int, int> prevMap;
    vector<int> result;

    for ( int i = 0; i < nums.size(); i++ )
    {
        int complement = target - nums[i];

        if ( prevMap.find( complement ) != prevMap.end() )
        {
            result.push_back( prevMap[complement] );
            result.push_back( i );
            break;
        }
        else
        {
            prevMap.insert( { nums[i], i } );
        }
    }

    return result;
}

int two_sum_main()
{
    vector<pair<vector<int>, int>> input_data =
    {
        { { 2, 7, 11, 15 }, 9 },  // [0,1]
        { { 3, 2, 4 },      6 },  // [1,2]
        { { 3, 3 },         6 }   // [0,1]
    };

    for ( int i = 0; i < input_data.size(); i++ )
    {
        vector<int> result = twoSumHash( input_data[i].first, input_data[i].second );

        printf( "[%i][%i]\r\n", result[0], result[1] );
    }

    return 0;
}