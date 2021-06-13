using System;
using System.Collections.Generic;
using System.Text;

namespace Top_Interview_Questions
{
    public static class LinkedListProblems
    {
        public static void DeleteNode(ListNode node)
        {
            if (node.next != null)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // We have added the dummy node to handle below use case:
            //Input: head = [1], n = 1
            //    Output:[]

            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode first = dummy;
            ListNode second = dummy;

            for (int i = 0; i < n + 1; i++)
            {
                first = first.next;

            }

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;
            return dummy.next;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode first = head;
            ListNode second = head.next;
            ListNode third = head;
            while (second != null)
            {
                third = second.next;
                second.next = first;
                first = second;
                second = third;
            }
            head.next = null;
            head = first;
            return head;
        }
    }
}
