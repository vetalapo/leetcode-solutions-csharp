#include <vector>
#include <iostream>
#include <unordered_map>

using namespace std;

// 1404 ms, 13.4 MB
vector<int> topKFrequent( vector<int>& nums, int k )
{
    unordered_map<int, int> frequency_map;

    for ( int i = 0; i < nums.size(); i++ )
    {
        frequency_map[nums[i]]++;
    }

    vector<int> result;

    for ( int i = 0; i < k; i++ )
    {
        pair<int, int> max;

        for ( auto it = frequency_map.begin(); it != frequency_map.end(); it++ )
        {
            if ( find( result.begin(), result.end(), it->first ) == result.end() && it->second > max.second )
            {
                max.first = it->first;
                max.second = it->second;
            }
        }

        result.push_back( max.first );
    }

    return result;
}

// 7 ms, 15.6 MB
vector<int> topKFrequentBucketSort( vector<int>& nums, int k )
{
    unordered_map<int, int> frequency_map;
    int input_size = nums.size();

    for ( int i = 0; i < input_size; i++ )
    {
        frequency_map[nums[i]]++;
    }

    vector<vector<int>> buckets( input_size + 1 );

    for ( auto it = frequency_map.begin(); it != frequency_map.end(); it++ )
    {
        buckets[it->second].push_back( it->first );
    }

    vector<int> result;

    for ( int i = input_size; i >= 0; i-- )
    {
        if ( result.size() >= k )
        {
            break;
        }
        
        if ( !buckets.empty() )
        {
            result.insert( result.end(), buckets[i].begin(), buckets[i].end() );
        }
    }

    return result;
}

int top_K_frequent_main()
{
    vector<pair<vector<int>, int>> inputData =
    {
        { { 1, 1, 1, 2, 2, 3 }, 2 }, // [ 1, 2 ]
        { { 1 }, 1 },                // [ 1 ]
        { { 1, 2, 2, 3, 3, 3 }, 3 }  // [ 3, 2, 1 ]
    };

    for ( int i = 0; i < inputData.size(); i++ )
    {
        vector<int> result = topKFrequentBucketSort( inputData[i].first, inputData[i].second );
        
        for ( int j = 0; j < result.size(); j++ )
        {
            printf( "%d ", result[j] );
        }

        cout << "\r\n";
    }

    return 0;
}
