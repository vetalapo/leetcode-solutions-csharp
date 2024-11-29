﻿/**
 * 3005
 * Count Elements With Maximum Frequency
 **
 * You are given an array nums consisting of positive integers.
 * Return the total frequencies of elements in nums such
 * that those elements all have the maximum frequency.
 *
 * The frequency of an element is the number of occurrences of that element in the array.
 *
 * Example 1:
 *   Input: nums = [1,2,2,3,1,4]
 *   Output: 4
 *   Explanation:
 *     The elements 1 and 2 have a frequency of 2 which is the maximum frequency in the array.
 *     So the number of elements in the array with maximum frequency is 4.
 *
 * Example 2:
 *   Input: nums = [1,2,3,4,5]
 *   Output: 5
 *   Explanation:
 *     All elements of the array have a frequency of 1 which is the maximum.
 *     So the number of elements in the array with maximum frequency is 5.
 *
 * Constraints:
 *   • 1 <= nums.length <= 100
 *   • 1 <= nums[i] <= 100
 *
 * Hint 1:
 *   Find frequencies of all elements of the array.
 *
 * Hint 2:
 *   Find the elements that have the maximum frequencies and count their total occurrences.
 **
 * https://leetcode.com/problems/count-elements-with-maximum-frequency/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class CountElementsWithMaximumFrequency
{
    public int MaxFrequencyElements( int[] nums )
    {
        Dictionary<int, int> countMap = [];

        foreach ( int num in nums )
        {
            if ( countMap.TryGetValue( num, out int value ) )
            {
                countMap[num] = ++value;
            }
            else
            {
                countMap[num] = 1;
            }
        }

        int maxFrequency = 0;

        foreach ( (int num, int frequency) in countMap )
        {
            maxFrequency = Math.Max( maxFrequency, frequency );
        }

        int result = 0;

        foreach ( (int num, int frequency) in countMap )
        {
            if ( frequency == maxFrequency )
            {
                result += frequency;
            }
        }

        return result;
    }
}
