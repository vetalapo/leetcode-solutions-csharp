/**
 * 412
 * Fizz Buzz
 **
 * Given an integer n, return a string array answer (1-indexed) where:
 *   • answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
 *   • answer[i] == "Fizz" if i is divisible by 3.
 *   • answer[i] == "Buzz" if i is divisible by 5.
 *   • answer[i] == i (as a string) if none of the above conditions are true.
 *
 * Example 1:
 *   Input: n = 3
 *   Output: ["1","2","Fizz"]
 *
 * Example 2:
 *   Input: n = 5
 *   Output: ["1","2","Fizz","4","Buzz"]
 *
 * Example 3:
 *   Input: n = 15
 *   Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 *
 * Constraints:
 *   • 1 <= n <= 10^4
 **
 * https://leetcode.com/problems/fizz-buzz/
***/

using System.Collections.Generic;
using System.Text;

namespace Problems;

public class FizzBuzzSolution
{
    public IList<string> FizzBuzz( int n )
    {
        List<string> result = [];

        for ( int i = 1; i <= n; i++ )
        {
            if ( i % 15 == 0 )
            {
                result.Add( "FizzBuzz" );
            }
            else if ( i % 5 == 0 )
            {
                result.Add( "Buzz" );
            }
            else if ( i % 3 == 0 )
            {
                result.Add( "Fizz" );
            }
            else
            {
                result.Add( i.ToString() );
            }
        }

        return result;
    }

    public IList<string> FizzBuzzBooleans( int n )
    {
        List<string> result = [];

        for ( int i = 1; i <= n; i++ )
        {
            bool isDivisibleBy3 = i % 3 == 0;
            bool isDivisibleBy5 = i % 5 == 0;

            if ( isDivisibleBy3 && isDivisibleBy5 )
            {
                result.Add( "FizzBuzz" );
            }
            else if ( isDivisibleBy3 )
            {
                result.Add( "Fizz" );
            }
            else if ( isDivisibleBy5 )
            {
                result.Add( "Buzz" );
            }
            else
            {
                result.Add( i.ToString() );
            }
        }

        return result;
    }

    public IList<string> FizzBuzzBooleansBackedByArray( int n )
    {
        string[] result = new string[n];

        for ( int i = 0; i < n; i++ )
        {
            int number = i + 1;
            bool isDivisibleBy3 = number % 3 == 0;
            bool isDivisibleBy5 = number % 5 == 0;

            if ( isDivisibleBy3 && isDivisibleBy5 )
            {
                result[i] = "FizzBuzz";
            }
            else if ( isDivisibleBy3 )
            {
                result[i] = "Fizz";
            }
            else if ( isDivisibleBy5 )
            {
                result[i] = "Buzz";
            }
            else
            {
                result[i] = number.ToString();
            }
        }

        return result;
    }

    public IList<string> FizzBuzzBooleansAndPreallocatedStrings( int n )
    {
        List<string> result = new();

        string fizzBuzz = "FizzBuzz";
        string fizz = "Fizz";
        string buzz = "Buzz";

        for ( int i = 1; i <= n; i++ )
        {
            bool isDivisibleBy3 = i % 3 == 0;
            bool isDivisibleBy5 = i % 5 == 0;

            if ( isDivisibleBy3 && isDivisibleBy5 )
            {
                result.Add( fizzBuzz );
            }
            else if ( isDivisibleBy3 )
            {
                result.Add( fizz );
            }
            else if ( isDivisibleBy5 )
            {
                result.Add( buzz );
            }
            else
            {
                result.Add( i.ToString() );
            }
        }

        return result;
    }

    public IList<string> FizzBuzzStringConcatenation( int n )
    {
        List<string> result = new();

        for ( int i = 1; i <= n; i++ )
        {
            bool isDivisibleBy3 = i % 3 == 0;
            bool isDivisibleBy5 = i % 5 == 0;

            string currentSeq = "";

            if ( isDivisibleBy3 )
            {
                currentSeq += "Fizz";
            }

            if ( isDivisibleBy5 )
            {
                currentSeq += "Buzz";
            }

            if ( string.IsNullOrEmpty( currentSeq ) )
            {
                currentSeq += i;
            }

            result.Add( currentSeq );
        }

        return result;
    }

    public IList<string> FizzBuzzStringBuilder( int n )
    {
        List<string> result = new();

        for ( int i = 1; i <= n; i++ )
        {
            bool isDivisibleBy3 = i % 3 == 0;
            bool isDivisibleBy5 = i % 5 == 0;

            StringBuilder stringBuilder = new();

            if ( isDivisibleBy3 )
            {
                stringBuilder.Append( "Fizz" );
            }

            if ( isDivisibleBy5 )
            {
                stringBuilder.Append( "Buzz" );
            }

            if ( stringBuilder.Length == 0 )
            {
                stringBuilder.Append( i );
            }

            result.Add( stringBuilder.ToString() );
        }

        return result;
    }
}
