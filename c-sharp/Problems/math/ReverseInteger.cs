﻿/**
 * 7
 * Reverse Integer
 **
 * Given a signed 32-bit integer x, return x with its digits reversed.
 * If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1],
 * then return 0.
 *
 * Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
 *
 * Example 1:
 *   Input: x = 123
 *   Output: 321
 *
 * Example 2:
 *   Input: x = -123
 *   Output: -321
 *
 * Example 3:
 *   Input: x = 120
 *   Output: 21
 *
 * Constraints: -2^31 <= x <= 2^31 - 1
 **
 * https://leetcode.com/problems/reverse-integer/
***/

using System;

namespace Problems;

public class ReverseInteger
{
    public int Reverse( int x )
    {
        int result = 0;

        try
        {
            checked
            {
                while ( Math.Abs( x ) > 0 )
                {
                    result = result * 10 + ( x % 10 );
                    x /= 10;
                }
            }
        }
        catch
        {
            return 0;
        }

        return result;
    }
}
