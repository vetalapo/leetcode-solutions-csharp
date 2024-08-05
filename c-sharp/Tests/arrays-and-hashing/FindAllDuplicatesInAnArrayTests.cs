using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

namespace Problems;

public class FindAllDuplicatesInAnArrayTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<int> FindDuplicatesTest( int[] nums ) =>
        new FindAllDuplicatesInAnArray().FindDuplicates( nums );

    [TestCaseSource( nameof( TestCases ) )]
    public IList<int> FindDuplicatesHashSetTest( int[] nums ) =>
        new FindAllDuplicatesInAnArray().FindDuplicatesHashSet( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }] ).Returns( new List<int> { 2, 3 } );
            yield return new TestCaseData( [new int[] { 1, 1, 2 }] ).Returns( new List<int> { 1 } );
            yield return new TestCaseData( [new int[] { 1 }] ).Returns( new List<int> { } );
        }
    }
}
