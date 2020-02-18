using System;
using System.Collections.Generic;

namespace Solution1
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var nodesSeen = new HashSet<ListNode>();
            while (head != null)
            {
                if (nodesSeen.Contains(head))
                {
                    return true;
                }

                nodesSeen.Add(head);
                head = head.next;
            }
            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
