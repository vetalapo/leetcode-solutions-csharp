/**
 * 876
 * Middle of the Linked List
 **
 * Given the head of a singly linked list, return the middle node of the linked list.
 * If there are two middle nodes, return the second middle node.
 **
 * https://leetcode.com/problems/middle-of-the-linked-list/
***/

namespace Problems;

public class MiddleOfTheLinkedList
{
    public ListNode MiddleNode( ListNode head )
    {
        ListNode middle = head;
        ListNode end = head;

        while ( end is not null && end.next is not null )
        {
            middle = middle.next;
            end = end.next.next;
        }

        return middle;
    }
}
