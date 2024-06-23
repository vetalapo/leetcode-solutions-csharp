/**
 * 19
 * Remove Nth Node From End of List
 **
 * Given the head of a linked list, remove the nth node from the end of the list and return its head.
 *
 * Example 1:
 *   Input: head = [1,2,3,4,5], n = 2
 *   Output: [1,2,3,5]
 *
 * Example 2:
 *   Input: head = [1], n = 1
 *   Output: []
 *
 * Example 3:
 *   Input: head = [1,2], n = 1
 *   Output: [1]
 *
 * Constraints:
 *   • The number of nodes in the list is sz.
 *   • 1 <= sz <= 30
 *   • 0 <= Node.val <= 100
 *   • 1 <= n <= sz
 *
 * Follow up: Could you do this in one pass?
 *
 * Hint 1:
 *   Maintain two pointers and update one with a delay of n steps.
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
