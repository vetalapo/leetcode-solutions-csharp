/**
 * 234
 * Palindrome Linked List
 **
 * Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
 *
 * Example 1:
 *   Input: head = [1,2,2,1]
 *   Output: true
 *
 * Example 2:
 *   Input: head = [1,2]
 *   Output: false
 *
 * Constraints:
 *   • The number of nodes in the list is in the range [1, 10^5].
 *   • 0 <= Node.val <= 9
 *
 * Follow up: Could you do it in O(n) time and O(1) space?
 **
 * https://leetcode.com/problems/palindrome-linked-list/
***/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
***/

namespace Problems;

public class PalindromeLinkedList
{
    public bool IsPalindrome( ListNode head )
    {
        ListNode fast = head;
        ListNode slow = head;

        // Find middle;
        while ( fast is not null && fast.next is not null )
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        // Reverse the second half
        ListNode prev = null;

        while ( slow is not null )
        {
            ListNode temp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = temp;
        }

        // Check if palindrome
        ListNode left = head;
        ListNode right = prev;

        while ( right is not null )
        {
            if ( left.val != right.val )
            {
                return false;
            }

            left = left.next;
            right = right.next;
        }

        return true;
    }
}
