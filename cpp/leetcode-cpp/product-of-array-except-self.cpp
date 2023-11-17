#include <vector>
#include <iostream>

using namespace std;


/*
    Given an integer array nums, return an array such that:
    answer[i] is equal to the product of all elements of nums except nums[i]
    Ex. nums = [1,2,3,4] -> [24,12,8,6], nums = [-1,1,0,-3,3] -> [0,0,9,0,0]

    Calculate prefix products forward, then postfix backwards in a 2nd pass

    Time: O(n)
    Space: O(1)
*/

static class Solution
{
    public:
    static vector<int> productExceptSelf( vector<int>& nums )
    {
        vector<int> result;

        for ( int i = 0; i < nums.size(); i++ )
        {
            int subResult = 1;

            vector<int> subArray = nums;
            subArray.erase( subArray.begin() + i );

            for ( int j = 0; j < subArray.size(); j++ )
            {
                subResult *= subArray[j];
            }

            result.push_back( subResult );
        }

        return result;
    }

    public:
    static vector<int> productExceptSelfF( vector<int>& nums )
    {
        int inputSize = nums.size();

        vector<int> result( inputSize, 1 );

        int prefix = 1;
        for ( int i = 0; i < inputSize; i++ )
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        int postfix = 1;
        for ( int i = inputSize - 1; i >= 0; i-- )
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }
};

int product_except_self_main()
{
    vector<vector<int>> input =
    {
        { 1, 2, 3, 4 },      // [24,12,8,6]
        { -1, 1, 0, -3, 3 }  // [0,0,9,0,0]
    };

    for ( int i = 0; i < input.size(); i++ )
    {
        vector<int> result = Solution::productExceptSelf( input[i] );

        for ( int j = 0; j < result.size(); j++ )
        {
            cout << result[j] << " ";
        }

        cout << "\r\n";
    }

    return 0;
}
