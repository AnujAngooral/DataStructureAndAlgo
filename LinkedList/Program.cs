using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);
            var node2 = new ListNode(0);
            node.next = node2;

            var node3 = new ListNode(1);
            node2.next = node3;
            //var node4 = new ListNode(3);
            //node3.next = node4;

            //var node5 = new ListNode(2);
            //node4.next = node5;

            //var node6 = new ListNode(1);
            //node5.next = node6;

            //var node7 = new ListNode(7);
            //node6.next = node7;

            var test = PalindromeLinkedList.IsPalindrome(node);
            Console.WriteLine("Hello World!");
        }
    }
}
