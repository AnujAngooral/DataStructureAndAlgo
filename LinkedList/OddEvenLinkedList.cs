using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class OddEvenLinkedList
    {
        public static ListNode oddEvenList(ListNode head)
        {

            if (head == null) return null;
            ListNode odd = head, even = head.next, evenHead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }
    }
}
