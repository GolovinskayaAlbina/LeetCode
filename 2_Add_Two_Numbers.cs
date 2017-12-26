/////////////////////////////////////////////
//You are given two non-empty linked lists representing two non-negative integers. 
//The digits are stored in reverse order and each of their nodes contain a single digit. 
//Add the two numbers and return it as a linked list.
//
//You may assume the two numbers do not contain any leading zero, except the number 0 itself.
/////////////////////////////////////////////
//Example
//
//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8
//Explanation: 342 + 465 = 807.
//
/////////////////////////////////////////////
using System;
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
 }

public partial class Solution {
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new ListNode(0);
        ListNode current = result;
        ListNode tmpL1 = l1;
        ListNode tmpL2 = l2;
        var remainder = 0;
        while(tmpL1 != null || tmpL2 != null || remainder > 0)
        {
            var l1Val = (tmpL1 == null) ? 0: tmpL1.val;
            var l2Val = (tmpL2 == null) ? 0: tmpL2.val;
            var sum = remainder + l1Val + l2Val;
            remainder = sum / 10;
            var node = new ListNode(sum % 10);
            current.next = node;
            current = current.next;
            
            tmpL1 = tmpL1?.next;
            tmpL2= tmpL2?.next;
        }
        return result.next;
    }
}
