using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._21___30.Problem21___MergeTwoSortedLists
{
    /// <summary>
    /// Solves problem 21.
    /// Accepted by LeetCode.
    /// Runtime: 84 ms, faster than 97.65% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }
    }
}
