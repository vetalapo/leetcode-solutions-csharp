﻿using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class FizzBuzzSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<string> FizzBuzzTest( int n ) =>
        new FizzBuzzSolution().FizzBuzz( n );

    [TestCaseSource( nameof( TestCases ) )]
    public IList<string> FizzBuzzBooleansTest( int n ) =>
        new FizzBuzzSolution().FizzBuzzBooleans( n );

    [TestCaseSource( nameof( TestCases ) )]
    public IList<string> FizzBuzzBooleansBackedByArrayTest( int n ) =>
        new FizzBuzzSolution().FizzBuzzBooleansBackedByArray( n );

    [TestCaseSource( nameof( TestCases ) )]
    public IList<string> FizzBuzzBooleansAndPreallocatedStringsTest( int n ) =>
        new FizzBuzzSolution().FizzBuzzBooleansAndPreallocatedStrings( n );

    [TestCaseSource( nameof( TestCases ) )]
    public IList<string> FizzBuzzStringConcatenationTest( int n ) =>
        new FizzBuzzSolution().FizzBuzzStringConcatenation( n );

    [TestCaseSource( nameof( TestCases ) )]
    public IList<string> FizzBuzzStringBuilderTest( int n ) =>
        new FizzBuzzSolution().FizzBuzzStringBuilder( n );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 3 )
                .Returns( new string[] { "1", "2", "Fizz" } );

            yield return new TestCaseData( 5 )
                .Returns( new string[] { "1", "2", "Fizz", "4", "Buzz" } );

            yield return new TestCaseData( 15 )
                .Returns( new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } );
        }
    }
}
