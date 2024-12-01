﻿/**
 * 1346
 * Check If N and Its Double Exist
 **
 * Given an array arr of integers, check if there exist two indices i and j such that:
 *   • i != j
 *   • 0 <= i, j < arr.length
 *   • arr[i] == 2 * arr[j]
 *
 * Example 1:
 *   Input: arr = [10,2,5,3]
 *   Output: true
 *   Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
 * 
 * Example 2:
 *   Input: arr = [3,1,7,11]
 *   Output: false
 *   Explanation: There is no i and j that satisfy the conditions.
 *
 * Constraints:
 *   • 2 <= arr.length <= 500
 *   • -10^3 <= arr[i] <= 10^3
 *
 * Hint 1:
 *   Loop from i = 0 to arr.length, maintaining in a hashTable the array elements from [0, i - 1].
 *
 * Hint 2:
 *   On each step of the loop check if we have seen the element 2 * arr[i] so far.
 *
 * Hint 3:
 *   Also check if we have seen arr[i] / 2 in case arr[i] % 2 == 0.
 **
 * https://leetcode.com/problems/check-if-n-and-its-double-exist/
***/

using System.Collections.Generic;

public class CheckIfNandItsDoubleExist
{
    public bool CheckIfExist( int[] arr )
    {
        HashSet<int> set = new( arr[0] );

        foreach ( int num in arr )
        {
            if ( set.Contains( num * 2 ) || ( num % 2 == 0 && set.Contains( num / 2 ) ) )
            {
                return true;
            }

            set.Add( num );
        }

        return false;
    }
}
