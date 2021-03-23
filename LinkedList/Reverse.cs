using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Reverse
    {
        public static ListNode ReverseLinkedlist(ListNode head)
        {
            ListNode currentNode = head;
            ListNode prevNode = null;
            ListNode nextNode = null;

            while (currentNode != null)
            {
                nextNode = currentNode.next;
                currentNode.next = prevNode;

                prevNode = currentNode;
                currentNode = nextNode;

            }

            head = prevNode;

            return head;
        }

    }
}
