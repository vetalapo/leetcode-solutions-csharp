﻿using System.Collections;

using NUnit.Framework;

using Problems;

public class RemoveNthNodeFromEndOfListTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode RemoveNthFromEndTest( ListNode head, int n ) =>
        new RemoveNthNodeFromEndOfList().RemoveNthFromEnd( head, n );

    [TestCaseSource( nameof( TestCases ) )]
    public ListNode RemoveNthFromEndProperTest( ListNode head, int n ) =>
        new RemoveNthNodeFromEndOfList().RemoveNthFromEndProper( head, n );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 2, 3, 4, 5] ), 2 )
                .Returns( ListNode.Create( [1, 2, 3, 5] ) );

            yield return new TestCaseData( ListNode.Create( [1] ), 1 )
                .Returns( ListNode.Create( [] ) );

            yield return new TestCaseData( ListNode.Create( [1, 2] ), 1 )
                .Returns( ListNode.Create( [1] ) );

            yield return new TestCaseData( ListNode.Create( [1, 2] ), 2 )
                .Returns( ListNode.Create( [2] ) );
        }
    }
}
