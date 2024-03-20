using System.Collections;

using NUnit.Framework;

using Problems;

public class MergeInBetweenLinkedListsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode MergeInBetweenTest( ListNode list1, int a, int b, ListNode list2 ) =>
        new MergeInBetweenLinkedLists().MergeInBetween( list1, a, b, list2 );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [10, 1, 13, 6, 9, 5] ), 3, 4, ListNode.Create( [1000000, 1000001, 1000002] ) )
                .Returns( ListNode.Create( [10, 1, 13, 1000000, 1000001, 1000002, 5] ) );

            yield return new TestCaseData( ListNode.Create( [0, 1, 2, 3, 4, 5, 6] ), 2, 5, ListNode.Create( [1000000, 1000001, 1000002, 1000003, 1000004] ) )
                .Returns( ListNode.Create( [0, 1, 1000000, 1000001, 1000002, 1000003, 1000004, 6] ) );
        }
    }
}
