#include <iostream>
#include <vector>
#include <unordered_set>

using namespace std;

bool containsDuplicate( vector<int>& nums )
{
    unordered_set<int> test_nums;

    for ( int i = 0; i < nums.size(); i++ )
    {
        if ( test_nums.find( nums[i] ) != test_nums.end() )
        {
            return true;
        }

        test_nums.insert( nums[i] );
    }

    return false;
}

int contains_duplicate_main()
{
    vector<vector<int>> inputArray =
    {
        { 1, 2, 3, 1 },                   // True
        { 1, 2, 3, 4 },                   // False
        { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }  // True
    };

    for ( int i = 0; i < inputArray.size(); i++ )
    {
        printf( "%s\r\n", containsDuplicate( inputArray[i] ) ? "True" : "False" );
    }

    return 0;
}
