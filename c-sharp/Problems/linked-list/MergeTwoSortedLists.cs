/**
* 21
* Merge Two Sorted Lists 
**
* You are given the heads of two sorted linked lists list1 and list2.
* 
* Merge the two lists into one sorted list.
* The list should be made by splicing together the nodes of the first two lists.
* 
* Return the head of the merged linked list.
* 
* Both list1 and list2 are sorted in non-decreasing order.
* 
* https://leetcode.com/problems/merge-two-sorted-lists/
*/

namespace Problems;

public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists( ListNode list1, ListNode list2 )
    {
        ListNode result = new();
        ListNode tail = result;

        while ( list1 is not null && list2 is not null )
        {
            if ( list1.val < list2.val )
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }

            tail = tail.next;
        }

        if ( list1 is not null || list2 is not null )
        {
            tail.next = list1 ?? list2;
        }

        return result.next;
    }

    public ListNode MergeTwoListsNaive( ListNode list1, ListNode list2 )
    {
        if ( list1 is null || list2 is null )
        {
            return list1 ?? list2;
        }

        if ( list2.val < list1.val )
        {
            (list1, list2) = (list2, list1);
        }

        List<int> nodesValues = new();

        while ( list1 is not null || list2 is not null )
        {
            if ( list1 is null || list2 is null )
            {
                ListNode list0 = list1 ?? list2;

                while ( list0 is not null )
                {
                    nodesValues.Add( list0.val );

                    list0 = list0.next;
                }

                break;
            }

            if ( list1.val <= list2.val )
            {
                nodesValues.Add( list1.val );
                list1 = list1.next;
            }
            else
            {
                nodesValues.Add( list2.val );
                list2 = list2.next;
            }
        }

        ListNode result = null;

        for ( int i = nodesValues.Count - 1; i >= 0; i-- )
        {
            result = new ListNode( nodesValues[i], result );
        }

        return result;
    }
}
