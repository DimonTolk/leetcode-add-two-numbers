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
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	  {
		  ListNode result = new ListNode((l1.val + l2.val) % 10);
		  ListNode index = result;
		  var nextValIncrement = (l1.val + l2.val) / 10;
		
		  l1 = l1.next;
		  l2 = l2.next;
		
		  while (l1 != null || l2 != null || nextValIncrement != 0)
		  {
			  var value = ((l1?.val ?? 0) + (l2?.val ?? 0) + nextValIncrement);
			  nextValIncrement = value / 10;
			
			  l1 = l1?.next;
			  l2 = l2?.next;
			
			  index.next = new ListNode(value % 10);
			  index = index.next;
		  }
		
		  return result;
	  }
}
