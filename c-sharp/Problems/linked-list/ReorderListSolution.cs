/**
 * 143
 * Reorder List
 **
 * You are given the head of a singly linked-list. The list can be represented as:
 *   L0 → L1 → … → Ln - 1 → Ln
 *
 * Reorder the list to be on the following form:
 *   L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …
 *
 * You may not modify the values in the list's nodes. Only nodes themselves may be changed.
 *
 * Example 1:
 *   Input: head = [1,2,3,4]
 *   Output: [1,4,2,3]
 *
 * Example 2:
 *   Input: head = [1,2,3,4,5]
 *   Output: [1,5,2,4,3]
 *
 * Constraints:
 *   • The number of nodes in the list is in the range [1, 5 * 10^4].
 *   • 1 <= Node.val <= 1000
 **
 * https://leetcode.com/problems/reorder-list/
***/

namespace Problems;

public class ReorderListSolution
{
    public void ReorderList( ref ListNode head )
    {
        // Splitting in two parts in half
        ListNode slow = head;
        ListNode fast = head.next;

        while ( fast is not null && fast.next is not null )
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = slow.next;
        slow.next = null;

        ListNode first = head;

        // Reversing second part
        ListNode previous = null;

        while ( second is not null )
        {
            ListNode temp = second.next;
            second.next = previous;

            previous = second;
            second = temp;
        }

        second = previous;

        // Merging first and second parts
        while ( second is not null )
        {
            // Preserving next values for the next step
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;

            // Criss cross update, will affect the head also
            first.next = second;
            second.next = temp1;

            // Moving pointers
            first = temp1;
            second = temp2;
        }
    }
}
