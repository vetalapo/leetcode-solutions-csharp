using System;
using System.Collections;

using NUnit.Framework;

using Problems;

public class ConcatenationOfArrayTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[] GetConcatenationTest( int[] nums ) => new ConcatenationOfArray().GetConcatenation( nums );

    [TestCaseSource( nameof( TestCases ) )]
    public int[] GetConcatenationSLTest( int[] nums ) => new ConcatenationOfArray().GetConcatenationSL( nums );

    [TestCaseSource( nameof( TestCases ) )]
    public int[] GetConcatenationSpanTest( int[] nums ) => new ConcatenationOfArray().GetConcatenationSpan( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 1, 2, 1 } ).Returns( new int[] { 1, 2, 1, 1, 2, 1 } );
            yield return new TestCaseData( new int[] { 1, 3, 2, 1 } ).Returns( new int[] { 1, 3, 2, 1, 1, 3, 2, 1 } );
            yield return new TestCaseData( Array.Empty<int>() ).Returns( Array.Empty<int>() );
        }
    }
}
