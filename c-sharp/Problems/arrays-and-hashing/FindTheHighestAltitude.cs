﻿/**
 * 1732
 * Find the Highest Altitude
 **
 * There is a biker going on a road trip.
 * The road trip consists of n + 1 points at different altitudes.
 * The biker starts his trip on point 0 with altitude equal 0.
 *
 * You are given an integer array gain of length n
 * where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1
 * for all (0 <= i < n).
 *
 * Return the highest altitude of a point.
 *
 * Example 1:
 * Input: gain = [-5,1,5,0,-7]
 * Output: 1
 * Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.
 *
 * Example 2:
 * Input: gain = [-4,-3,-2,-1,4,3,2]
 * Output: 0
 * Explanation: The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0.
 *
 * Constraints:
 * n == gain.length
 * 1 <= n <= 100
 * -100 <= gain[i] <= 100
 *
 * Hint 1:
 *   Let's note that the altitude of an element is the sum of gains of all the elements behind it
 *
 * Hint 2:
 *   Getting the altitudes can be done by getting the prefix sum array of the given array
 **
 * https://leetcode.com/problems/find-the-highest-altitude/
***/

using System;

namespace Problems;

public class FindTheHighestAltitude
{
    public int LargestAltitude( int[] gain )
    {
        int max = 0;
        int runningSum = 0;

        foreach ( int num in gain )
        {
            runningSum += num;
            max = Math.Max( max, runningSum );
        }

        return max;
    }
}
