using System;

namespace Top_Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);

            //var node2 = new ListNode(2);
            //node.next = node2;

            //var node3 = new ListNode(3);
            //node2.next = node3;

            //var node4 = new ListNode(4);
            //node3.next = node4;

            //var node5 = new ListNode(5);
            //node4.next = node5;

            LinkedListProblems.RemoveNthFromEnd(node, 1);
            Console.WriteLine("Hello World!");
        }
    }
}
