using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            ListNode p = head, q = head;
            ListNode secondHalf = null;
            while (true)
            {
                p = p.next.next;
                if (p == null)
                {
                    secondHalf = q.next;
                    break;
                }
                if (p.next == null)
                {
                    secondHalf = q.next.next;
                    break;
                }

                q = q.next;
            }
            q.next = null;
            var reversedList = Reverse(secondHalf);
            var firstHalf = head;
            while (firstHalf != null && reversedList != null)
            {
                if (firstHalf.val != reversedList.val)
                    return false;
                firstHalf = firstHalf.next;
                reversedList = reversedList.next;
            }

            return true;
        }

        private static ListNode Reverse(ListNode node)
        {
            ListNode currentNode = node;
            ListNode prevNode = null;
            ListNode nextNode = null;

            while (currentNode != null)
            {
                nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }

            return prevNode;
        }
    }
}
