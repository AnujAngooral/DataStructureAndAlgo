using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class RemoveLinkedListElements
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return head;
            if (head.next == null && head.val == val)
            {
                head = null;
                return head;
            }
            ListNode dummyNode = new ListNode(0);
            dummyNode.next = head;
            ListNode currentNode = head;
            ListNode prevNode = dummyNode;
            while (currentNode != null)
            {
                if (currentNode.val == val)
                {

                    prevNode.next = currentNode.next;
                }
                else
                {
                    prevNode = currentNode;
                }

                currentNode = currentNode.next;
            }

            return dummyNode.next;
        }
    }
}
