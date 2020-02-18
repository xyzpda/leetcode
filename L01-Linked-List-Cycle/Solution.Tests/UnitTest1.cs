using System;
using Xunit;
using Solution1;

namespace Solution1.Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// Example 1:
        /// Input: head = [3,2,0,-4], pos = 1
        /// Output: true
        /// Explanation: There is a cycle in the linked list, where tail connects to the second node.
        /// 
        /// </summary>
        [Fact]
        public void HasCycle_Example1_ReturnTrue()
        {
            var ln0 = new ListNode(3);
            var ln1 = new ListNode(2);
            var ln2 = new ListNode(0);
            var ln3 = new ListNode(-4);

            ln0.next = ln1;
            ln1.next = ln2;
            ln2.next = ln3;
            ln3.next = ln1;

            var solution = new Solution();

            Assert.True(solution.HasCycle(ln1));
        }

        /// <summary>
        /// Example 2:
        /// Input: head = [1,2], pos = 0
        /// Output: true
        /// Explanation: There is a cycle in the linked list, where tail connects to the first node.
        /// </summary>
        [Fact]
        public void HasCycle_Example2_ReturnTrue()
        {
            var ln0 = new ListNode(1);
            var ln1 = new ListNode(2);

            ln0.next = ln1;
            ln1.next = ln0;

            var solution = new Solution();

            Assert.True(solution.HasCycle(ln0));
        }

        /// <summary>
        /// Example 3:
        /// Input: head = [1,2], pos = 0
        /// Output: false
        /// Explanation: There is no cycle in the linked list.
        /// </summary>
        [Fact]
        public void HasCycle_Example3_ReturnFalse()
        {
            var ln0 = new ListNode(1);

            var solution = new Solution();

            Assert.False(solution.HasCycle(ln0));
        }
    }
}
