using System.Collections;

using NUnit.Framework;

using Problems;

public class ReverseLinkedListTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode ReverseListIterativelyTest( ListNode head ) =>
        new ReverseLinkedList().ReverseListIteratively( head );

    [TestCaseSource( nameof( TestCases ) )]
    public ListNode ReverseListTest( ListNode head ) =>
        new ReverseLinkedList().ReverseList( head );

    [TestCaseSource( nameof( TestCases ) )]
    public ListNode ReverseListRightWayTest( ListNode head ) =>
        new ReverseLinkedList().ReverseListRightWay( head );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 2, 3, 4, 5] ) )
                .Returns( ListNode.Create( [5, 4, 3, 2, 1] ) );

            yield return new TestCaseData( ListNode.Create( [1, 2] ) )
                .Returns( ListNode.Create( [2, 1] ) );

            yield return new TestCaseData( null ).Returns( null );
        }
    }
}
