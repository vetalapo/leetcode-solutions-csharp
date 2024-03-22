using System.Collections;

using NUnit.Framework;

using Problems;

public class PalindromeLinkedListTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool IsPalindromeTest( ListNode head ) =>
        new PalindromeLinkedList().IsPalindrome( head );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 2, 2, 1] ) ).Returns( true );
            yield return new TestCaseData( ListNode.Create( [1, 2] ) ).Returns( false );
        }
    }
}
