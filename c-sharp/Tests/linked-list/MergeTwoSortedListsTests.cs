using System.Collections;

using NUnit.Framework;

using Problems;


public class MergeTwoSortedListsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode MergeTwoListsTest( ListNode list1, ListNode list2 ) =>
        new MergeTwoSortedLists().MergeTwoLists( list1, list2 );

    [TestCaseSource( nameof( TestCases ) )]
    public ListNode MergeTwoListsNaiveTest( ListNode list1, ListNode list2 ) =>
        new MergeTwoSortedLists().MergeTwoListsNaive( list1, list2 );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 2, 4] ), ListNode.Create( [1, 3, 4] ) )
                .Returns( ListNode.Create( [1, 1, 2, 3, 4, 4] ) );

            yield return new TestCaseData( ListNode.Create( [2, 4, 6, 8] ), ListNode.Create( [1, 3, 5, 7] ) )
                .Returns( ListNode.Create( [1, 2, 3, 4, 5, 6, 7, 8] ) );

            yield return new TestCaseData( null, null )
                .Returns( null );

            yield return new TestCaseData( null, ListNode.Create( [0] ) )
                .Returns( ListNode.Create( [0] ) );

            yield return new TestCaseData( ListNode.Create( [5, 6] ), null )
                .Returns( ListNode.Create( [5, 6] ) );

            yield return new TestCaseData( ListNode.Create( [5] ), ListNode.Create( [1, 2, 4] ) )
                .Returns( ListNode.Create( [1, 2, 4, 5] ) );
        }
    }
}
