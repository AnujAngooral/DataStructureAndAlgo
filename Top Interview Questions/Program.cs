using System;

namespace Top_Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {

         int max= MultipleProblems.LengthOfLongestSubstring("abcabcbb");


            ListNode node = new ListNode(1);

            var node2 = new ListNode(2);
            node.next = node2;

            var node3 = new ListNode(2);
            node2.next = node3;

            var node4 = new ListNode(1);
            node3.next = node4;

            //var node5 = new ListNode(5);
            //node4.next = node5;


            //ListNode node20 = new ListNode(1);

            //var node21 = new ListNode(2);
            //node20.next = node21;

            //var node31 = new ListNode(3);
            //node21.next = node31;

            //var node41 = new ListNode(4);
            //node31.next = node41;

            //var node51 = new ListNode(5);
            //node41.next = node51;

            LinkedListProblems.IsPalindrome(node);
            Console.WriteLine("Hello World!");
        }
    }
}
