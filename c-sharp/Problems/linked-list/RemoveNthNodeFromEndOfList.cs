/**
 * 19
 * Remove Nth Node From End of List
 **
 * Given the head of a linked list, remove the nth node from the end of the list and return its head.
 *
 * Follow up: Could you do this in one pass?
 **
 * https://leetcode.com/problems/remove-nth-node-from-end-of-list/
***/

namespace Problems;

public class RemoveNthNodeFromEndOfList
{
    int i = 0;
    ListNode temp = null;

    public ListNode RemoveNthFromEnd( ListNode head, int n )
    {
        if ( head is null )
        {
            return null;
        }

        RemoveNthFromEnd( head.next, n );

        i++;

        if ( i == n )
        {
            temp = head.next;
            head = null;
        }

        if ( i > n )
        {
            head.next = temp;
            temp = head;
        }

        return head ?? temp;
    }

    public ListNode RemoveNthFromEndProper( ListNode head, int n )
    {
        ListNode dummy = new( 0, head );
        ListNode left = dummy;
        ListNode right = head;

        while ( n > 0 )
        {
            right = right.next;
            n--;
        }

        while ( right is not null )
        {
            left = left.next;
            right = right.next;
        }

        // Deleting node
        left.next = left.next.next;

        return dummy.next;
    }
}
