using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem2___AddTwoNumbers
{
    /// <summary>
    /// Solves problem 2.
    /// Accepted by LeetCode.
    /// Runtime: 96 ms, faster than 98.56% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class TwoNumbersAdder
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Add(l1, l2, 0);
        }

        private static ListNode Add(ListNode l1, ListNode l2, int carry)
        {
            int node1Value = l1?.val ?? 0;
            int node2Value = l2?.val ?? 0;
            int sum = node1Value + node2Value + carry;

            if (l1 == null && l2 == null)
            {
                return carry == 0 ? null : new ListNode(carry);
            }
            else
            {
                ListNode current = new ListNode(sum % 10);

                ListNode head = Add(l1?.next, l2?.next, sum / 10);

                if (head == null)
                {
                    head = current;
                }
                else
                {
                    head = AddToBegining(head, current);
                }
                return head;
            }
        }

        private static ListNode AddToBegining(ListNode lhead, ListNode other)
        {
            other.next = lhead;

            return other;
        }
    }
}