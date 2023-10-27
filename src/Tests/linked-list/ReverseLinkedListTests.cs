using System.Collections;

using NUnit.Framework;

using Problems;

[TestFixture]
public class ReverseLinkedListTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode ReverseListIterativelyTest( ListNode head ) => new ReverseLinkedList().ReverseListIteratively( head );

    [TestCaseSource( nameof( TestCases ) )]
    public ListNode ReverseListTest( ListNode head ) => new ReverseLinkedList().ReverseList( head );

    [TestCaseSource( nameof( TestCases ) )]
    public ListNode ReverseListRightWayTest( ListNode head ) => new ReverseLinkedList().ReverseListRightWay( head );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.CreateNodes( new int[] { 1, 2, 3, 4, 5 } ) )
                .Returns( ListNode.CreateNodes( new int[] { 5, 4, 3, 2, 1 } ) );

            yield return new TestCaseData( ListNode.CreateNodes( new int[] { 1, 2 } ) )
                .Returns( ListNode.CreateNodes( new int[] { 2, 1 } ) );

            yield return new TestCaseData( null ).Returns( null );
        }
    }
}
