using System.Text;

namespace leet_code_csharp.math;

public class FizzBuzzSolution
{
    public IList<string> FizzBuzz( int n )
    {
        List<string> result = new();

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
        List<string> result = new();

        for ( int i = 1; i <= n; i++ )
        {
            bool isDivisibleBy3 = i % 3 == 0;
            bool isDivisibleBy5 = i % 5 == 0;

            if ( isDivisibleBy3 && isDivisibleBy5 )
            {
                result.Add( "FizzBuzz" );
            }
            else if ( isDivisibleBy5 )
            {
                result.Add( "Buzz" );
            }
            else if ( isDivisibleBy3 )
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
