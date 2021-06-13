using System;
using System.Collections.Generic;
using System.Text;

namespace Top_Interview_Questions
{
    public class LinkedListProblems
    {
        public void DeleteNode(ListNode node)
        {
            if (node.next != null)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
    }
}
