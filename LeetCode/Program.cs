using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4] { 3, 4, -1, 1 };

            Console.WriteLine(FirstMissingPositive(nums));

            Console.ReadKey();
        }

        public int FirstMissingPositive(int[] nums)
        {
            List<int> positives = new List<int>();

            foreach (int num in nums)
            {
                if (num > 0)
                {
                    positives.Add(num);
                }
            }


        }
    }
}



//problem 23
/*
ListNode a = new ListNode(-3,
     new ListNode(-2,
     new ListNode(-1, null)));
ListNode b = new ListNode(-3,
             new ListNode(-2,
             new ListNode(-1, null)));
ListNode c = new ListNode(-3,
             new ListNode(-2,
             new ListNode(-1, null)));


ListNode d = null;
ListNode e = new ListNode(-2,
             new ListNode(-1,
             new ListNode(-1, null)));
ListNode f = null;
ListNode g = new ListNode(6,
             new ListNode(10, null));

ListNode[] lists = new ListNode{3} { a, b, c };

public static ListNode MergeKLists(ListNode[] lists)
{
    ListNode head = null;
    if (lists.Length > 0) 
    {
        head = lists{0};
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

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}*/

//problem 37
/*
        char[][] board1 = new char[9][];
        board1[0] = new char[9] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
    board1[1] = new char[9] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
board1[2] = new char[9] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
board1[3] = new char[9] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
board1[4] = new char[9] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
board1[5] = new char[9] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
board1[6] = new char[9] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
board1[7] = new char[9] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
board1[8] = new char[9] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };



char[][] board2 = new char[9][];
board2[0] = new char[9] { '.', '.', '9', '7', '4', '8', '.', '.', '.' };
board2[1] = new char[9] { '7', '.', '.', '.', '.', '.', '.', '.', '.' };
board2[2] = new char[9] { '.', '2', '.', '1', '.', '9', '.', '.', '.' };
board2[3] = new char[9] { '.', '.', '7', '.', '.', '.', '2', '4', '.' };
board2[4] = new char[9] { '.', '6', '4', '.', '1', '.', '5', '9', '.' };
board2[5] = new char[9] { '.', '9', '8', '.', '.', '.', '3', '.', '.' };
board2[6] = new char[9] { '.', '.', '.', '8', '.', '3', '.', '2', '.' };
board2[7] = new char[9] { '.', '.', '.', '.', '.', '.', '.', '.', '6' };
board2[8] = new char[9] { '.', '.', '.', '2', '7', '5', '9', '.', '.' };
SolveSudoku(board2);

public static void SolveSudoku(char[][] board)
        {
            start:
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        List<char> options = GetOptions(board, i, j);
                        if (options.Count == 1)
                        { 
                            board[i][j] = options[0];
                            goto start;

                        }
                    }
                }
            }
        }

        public static List<char> GetOptions(char[][] board, int i, int j)
        {
            List<char> options = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach(char chr in board[i])
            {
                if (chr != '.') 
                {
                    options.Remove(chr);
                }
            }

            for (int k = 0; k < 9; k++)
            {
                if (board[k][j] != '.')
                {
                    options.Remove(board[k][j]);
                }
            }

            for (int k = i - i % 3; k < i - i % 3 + 3; k++)
            {
                for (int m = j - j % 3; m < j - j % 3 + 3; m++)
                {
                    if (board[k][m] != '.')
                    {
                        options.Remove(board[k][m]);
                    }
                }
            }

            return options;
        }*/

//problems 41
//Runtime: 88 ms, faster than 83.65% of C# online submissions for First Missing Positive.
/*
        public static int FirstMissingPositive(int[] nums)
        {
            List<int> positives = new List<int>();

            foreach(int num in nums)
            {
                if (num > 0)
                {
                    positives.Add(num);
                }
            }

            if (positives.Count == 0)
            {
                return 1;
            }


            positives.Sort();

            int ans = 1;

            int i = 0;
            for (; i < positives.Count;)
            {
                if(positives[i] != ans)
                {
                    return ans;
                }

                while (i < positives.Count && positives[i] == ans) 
                {
                    i++;
                }
                ans++;
            }

            return ans;
        }*/