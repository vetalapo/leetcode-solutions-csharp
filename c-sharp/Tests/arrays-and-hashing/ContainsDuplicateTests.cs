using System.Collections;

using NUnit.Framework;

using Problems;

public class ContainsDuplicateTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool ContainsDuplicateTest( int[] nums ) =>
        new ContainsDuplicateSolution().ContainsDuplicate( nums );

    [TestCaseSource( nameof( TestCases ) )]
    public bool ContainsDuplicateAltTest( int[] nums ) =>
        new ContainsDuplicateSolution().ContainsDuplicateAlt( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 1, 2, 3, 1 } ).Returns( true );
            yield return new TestCaseData( new int[] { 1, 2, 3, 4 } ).Returns( false );
            yield return new TestCaseData( new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 } ).Returns( true );
        }
    }
}
