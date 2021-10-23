using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._0031___0040.Problem36___ValidSudoku
{
    /// <summary>
    /// Solves problem 36.
    /// Accepted by LeetCode.
    /// Runtime: 104 ms, faster than 90.89% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            //Rows
            for (int i = 0; i < 9; i++)
            {
                bool[] candidates = new bool[9] { false, false, false,
                                                  false, false, false,
                                                  false, false, false };
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        int num = int.Parse(board[i][j].ToString());

                        if (candidates[num - 1] == false)
                        {
                            candidates[num - 1] = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            //Columns
            for (int i = 0; i < 9; i++)
            {
                bool[] candidates = new bool[9] { false, false, false,
                                                  false, false, false,
                                                  false, false, false };
                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] != '.')
                    {
                        int num = int.Parse(board[j][i].ToString());

                        if (candidates[num - 1] == false)
                        {
                            candidates[num - 1] = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            //Squers
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    bool[] candidates = new bool[9] { false, false, false,
                                                  false, false, false,
                                                  false, false, false };

                    for (int k = i - i % 3; k < i - i % 3 + 3; k++)
                    {
                        for (int m = j - j % 3; m < j - j % 3 + 3; m++)
                        {
                            if (board[k][m] != '.')
                            {
                                int num = int.Parse(board[k][m].ToString());

                                if (candidates[num - 1] == false)
                                {
                                    candidates[num - 1] = true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
