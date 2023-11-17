/**
 * 206
 * Reverse Linked List
 **
 * Given the head of a singly linked list, reverse the list, and return the reversed list.
 * 
 * Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?
 * 
 * https://leetcode.com/problems/reverse-linked-list/
 */

namespace Problems;

public class ReverseLinkedList
{
    public ListNode ReverseListIteratively( ListNode head )
    {
        ListNode result = null;

        while ( head is not null )
        {
            result = new ListNode( head.val, result );

            head = head.next;
        }

        return result;
    }

    public ListNode ReverseList( ListNode head, ListNode? accumulator = null )
    {
        if ( head == null )
        {
            return null;
        }

        if ( head.next is null )
        {
            return new ListNode( head.val, accumulator );
        }

        return ReverseList( head.next, new ListNode( head.val, accumulator ) );
    }

    public ListNode ReverseListRightWay( ListNode head )
    {
        ListNode previous = null;

        while ( head is not null )
        {
            ListNode temp = head.next;
            head.next = previous;

            // Updating pointers
            previous = head;
            head = temp;
        }

        return previous;
    }
}
