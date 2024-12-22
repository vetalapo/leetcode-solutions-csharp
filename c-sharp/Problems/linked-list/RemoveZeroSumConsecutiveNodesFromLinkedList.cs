/**
 * 1171
 * Remove Zero Sum Consecutive Nodes from Linked List
 **
 * Given the head of a linked list,
 * we repeatedly delete consecutive sequences of nodes that sum to 0 until there are no such sequences.
 *
 * After doing so, return the head of the final linked list.
 * You may return any such answer.
 * (Note that in the examples below, all sequences are serializations of ListNode objects.)
 *
 * Example 1:
 *   Input: head = [1,2,-3,3,1]
 *   Output: [3,1]
 *   Note: The answer [1,2,1] would also be accepted.
 *
 * Example 2:
 *   Input: head = [1,2,3,-3,4]
 *   Output: [1,2,4]
 *
 * Example 3:
 *   Input: head = [1,2,3,-3,-2]
 *   Output: [1]
 *
 * Constraints:
 *   • The given linked list will contain between 1 and 1000 nodes.
 *   • Each node in the linked list has -1000 <= node.val <= 1000.
 *
 * Hint 1: Convert the linked list into an array.
 * Hint 2: While you can find a non-empty subarray with sum = 0, erase it.
 * Hint 3: Convert the array into a linked list.
 **
 * https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list/
***/

using System.Collections.Generic;

namespace Problems;

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
 */
public class RemoveZeroSumConsecutiveNodesFromLinkedList
{
    public ListNode RemoveZeroSumSublists( ListNode head )
    {
        ListNode front = new( 0, head );
        ListNode current = front;

        int prefixSum = 0;
        Dictionary<int, ListNode> prefixSumToNode = [];

        while ( current != null )
        {
            // Add current's value to the prefix sum
            prefixSum += current.val;

            // If prefixSum is already in the HashMap,
            // we have found a zero-sum sequence
            if ( prefixSumToNode.TryGetValue( prefixSum, out ListNode prev ) )
            {
                current = prev.next;

                // Delete zero sum nodes from HashMap
                // to prevent incorrect deletions from linked list
                int p = prefixSum + current.val;
                while ( p != prefixSum )
                {
                    prefixSumToNode.Remove( p );
                    current = current.next;
                    p += current.val;
                }

                // Make connection from the node before
                // the zero sum sequence to the node after
                prev.next = current.next;
            }
            else
            {
                prefixSumToNode.Add( prefixSum, current );
            }

            // Progress to next element in list
            current = current.next;
        }

        return front.next;
    }
}
