using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._21___30.Problem24___SwapNodesInPairs
{
    /// <summary>
    /// Solves problem 24.
    /// Accepted by LeetCode.
    /// Runtime: 84 ms, faster than 94.08% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class SwapNodesInPairs
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            else
            {
                ListNode newHead = head.next;
                ListNode prev = null;

                for (ListNode i = head, j = head.next; j != null;)
                {
                    i.next = j.next;
                    j.next = i;

                    if (prev != null)
                    {
                        prev.next = j;
                    }

                    prev = i;

                    i = i.next;
                    j = i?.next;
                }

                return newHead;
            }
        }
    }
}
