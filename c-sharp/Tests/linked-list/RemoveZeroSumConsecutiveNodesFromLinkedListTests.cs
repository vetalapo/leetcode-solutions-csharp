using System.Collections;

using NUnit.Framework;

using Problems;

public class RemoveZeroSumConsecutiveNodesFromLinkedListTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode RemoveZeroSumSublistsTest( ListNode head ) =>
        new RemoveZeroSumConsecutiveNodesFromLinkedList().RemoveZeroSumSublists( head );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 2, -3, 3, 1] ) )
                .Returns( ListNode.Create( [3, 1] ) );

            yield return new TestCaseData( ListNode.Create( [1, 2, 3, -3, 4] ) )
                .Returns( ListNode.Create( [1, 2, 4] ) );

            yield return new TestCaseData( ListNode.Create( [1, 2, 3, -3, -2] ) )
                .Returns( ListNode.Create( [1] ) );
        }
    }
}
