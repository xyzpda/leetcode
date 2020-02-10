using System;
using System.Collections.Generic;

namespace _01.Linked_List_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/linked-list-cycle/

            var solution = new Solution();

            // Example 1:

            // Input: head = [3,2,0,-4], pos = 1
            // Output: true
            // Explanation: There is a cycle in the linked list, where tail connects to the second node.


            {
                Console.WriteLine("Example 1:");

                var ln0 = new ListNode(3);
                var ln1 = new ListNode(2);
                var ln2 = new ListNode(0);
                var ln3 = new ListNode(-4);

                ln0.next = ln1;
                ln1.next = ln2;
                ln2.next = ln3;
                ln3.next = ln1;

                Console.WriteLine(solution.HasCycle(ln1));
            }

            // Example 2:

            // Input: head = [1,2], pos = 0
            // Output: true
            // Explanation: There is a cycle in the linked list, where tail connects to the first node.

            {
                Console.WriteLine("Example 1:");

                var ln0 = new ListNode(1);
                var ln1 = new ListNode(2);

                ln0.next = ln1;
                ln1.next = ln0;

                Console.WriteLine(solution.HasCycle(ln0));
            }

            // Input: head = [1], pos = -1
            // Output: false
            // Explanation: There is no cycle in the linked list.

            {
                Console.WriteLine("Example 1:");

                var ln0 = new ListNode(1);

                Console.WriteLine(solution.HasCycle(ln0));
            }
        }
    }

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

        // First
        // public bool HasCycle(ListNode head)
        // {
        //     var headVal = head.val;
        //     ListNode nextNode = head.next;

        //     while(nextNode != null)
        //     {
        //         if(headVal == nextNode.val)
        //         {
        //             return true;
        //         }

        //         nextNode = nextNode.next;
        //     }

        //     return false;
        // }
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


// Given a linked list, determine if it has a cycle in it.

// To represent a cycle in the given linked list, we use an integer pos which represents the position (0-indexed) in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.

 

// Example 1:

// Input: head = [3,2,0,-4], pos = 1
// Output: true
// Explanation: There is a cycle in the linked list, where tail connects to the second node.


// Example 2:

// Input: head = [1,2], pos = 0
// Output: true
// Explanation: There is a cycle in the linked list, where tail connects to the first node.


// Example 3:

// Input: head = [1], pos = -1
// Output: false
// Explanation: There is no cycle in the linked list.



// Follow up:

// Can you solve it using O(1) (i.e. constant) memory?

// public boolean hasCycle(ListNode head) {
//     Set<ListNode> nodesSeen = new HashSet<>();
//     while (head != null) {
//         if (nodesSeen.contains(head)) {
//             return true;
//         } else {
//             nodesSeen.add(head);
//         }
//         head = head.next;
//     }
//     return false;
// }

// public boolean hasCycle(ListNode head) {
//     if (head == null || head.next == null) {
//         return false;
//     }
//     ListNode slow = head;
//     ListNode fast = head.next;
//     while (slow != fast) {
//         if (fast == null || fast.next == null) {
//             return false;
//         }
//         slow = slow.next;
//         fast = fast.next.next;
//     }
//     return true;
// }