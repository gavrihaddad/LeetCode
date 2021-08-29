using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._21___30.Problem23___MergekSortedLists
{
    /// <summary>
    /// Solves problem 23.
    /// Accepted by LeetCode.
    /// Runtime: 96 ms, faster than 99.58% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static partial class MergekSortedLists
    {
        #region Solution 1: All in one, non-recursive, relatively slow.

        public static ListNode MergeKLists1(ListNode[] lists)
        {
            ListNode head = null;
            if (lists.Length > 0)
            {
                head = lists[0];
            }

            for (int i = 1; i < lists.Length; i++)
            {
                ListNode tempHead = head;

                while (lists[i] != null)
                {
                    ListNode prev = null;
                    while (tempHead != null && tempHead.val <= lists[i].val)
                    {
                        prev = tempHead;
                        tempHead = tempHead.next;
                    }

                    if (prev == null)
                    {
                        head = new ListNode(lists[i].val, head);
                        tempHead = head;
                    }
                    else
                    {
                        ListNode newNode = new ListNode(lists[i].val, tempHead);
                        prev.next = newNode;
                        tempHead = newNode;
                    }

                    lists[i] = lists[i].next;
                }
            }

            return head;
        }

        #endregion

        #region Solution 2: A little more broken down, non-recursive, relatively slow.

        public static ListNode MergeKLists2(ListNode[] lists)
        {
            ListNode head = null;
            if (lists.Length > 0)
            {
                head = lists[0];
            }

            for (int i = 1; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    InsertNode(lists[i].val);
                    lists[i] = lists[i].next;
                }
            }

            return head;

            void InsertNode(int val)
            {
                ListNode tempHead = head;
                ListNode prev = null;
                while (tempHead != null && tempHead.val < val)
                {
                    prev = tempHead;
                    tempHead = tempHead.next;
                }

                ListNode node = new ListNode(val, tempHead);
                if (prev != null)
                {
                    prev.next = node;
                }
                else
                {
                    head = node;
                }
            }
        }

        #endregion

        #region Solution 3: recursive, fast.

        public static ListNode MergeKLists3(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }
            return Merge(0, lists.Length - 1);

            ListNode Merge(int i, int j)
            {
                if (i == j)
                {
                    return lists[i];
                }
                else
                {
                    int mid = i + (j - i) / 2;
                    ListNode leftList = Merge(i, mid);
                    ListNode rightList = Merge(mid + 1, j);
                    return MergeTwoLists(leftList, rightList);
                }
            }
            ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                if (list1 == null)
                {
                    return list2;
                }
                else if (list2 == null)
                {
                    return list1;
                }
                else if (list1.val < list2.val)
                {
                    list1.next = MergeTwoLists(list1.next, list2);
                    return list1;
                }
                else
                {
                    list2.next = MergeTwoLists(list1, list2.next);
                    return list2;
                }
            }
        }

        #endregion
    }
}
