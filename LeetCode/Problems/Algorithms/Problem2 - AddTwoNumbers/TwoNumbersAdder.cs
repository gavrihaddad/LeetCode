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
    /// Runtime: 96 ms, faster than 98.62% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class TwoNumbersAdder
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Add(l1, l2, 0);
        }

        private static ListNode Add(ListNode l1, ListNode l2, int carry)
        {
            int x = (l1 != null) ? l1.val : 0; // The curren digits to add up.
            int y = (l2 != null) ? l2.val : 0;

            ListNode l1next = (l1 != null) ? l1.next : null; // The next nodes in the lists.
            ListNode l2next = (l2 != null) ? l2.next : null;

            int sum = x + y + carry; // The result of the adding.

            if (l1 != null || l2 != null) // While at least one of the lists is not over.
            {
                ListNode current = new ListNode(sum % 10); // The current node (with value).

                ListNode head = Add(l1next, l2next, sum / 10); // The one before current
                                                               // is the result of adding
                                                               // the next two digits (With carry).

                if (head == null) // The last tow digits.
                {
                    head = current;
                }
                else
                {
                    head = AddToBegining(head, current); // Adding to begining because the numbers 
                                                         // are suposed to be backwards in the result.
                }
                return head;
            }
            else
            {
                if (carry == 0)
                {
                    return null;
                }
                else
                {
                    return new ListNode(carry); // If we still have a carry it is
                                                // the first digit in the answer.
                }
            }
        }

        private static ListNode AddToBegining(ListNode lhead, ListNode other)
        {
            other.next = lhead;

            return other;
        }
    }
}