using System.Collections;

using NUnit.Framework;

using Problems;

public class ReorderListSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode ReorderListTest( ListNode head )
    {
        new ReorderListSolution().ReorderList( ref head );

        return head;
    }

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 2, 3, 4] ) )
                .Returns( ListNode.Create( [1, 4, 2, 3] ) );

            yield return new TestCaseData( ListNode.Create( [1, 2, 3, 4, 5] ) )
                .Returns( ListNode.Create( [1, 5, 2, 4, 3] ) );

            yield return new TestCaseData( ListNode.Create( [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12] ) )
                .Returns( ListNode.Create( [1, 12, 2, 11, 3, 10, 4, 9, 5, 8, 6, 7] ) );
        }
    }
}
