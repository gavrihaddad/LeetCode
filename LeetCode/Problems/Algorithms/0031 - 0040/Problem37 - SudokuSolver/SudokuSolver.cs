using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._0031___0040.Problem37___SudokuSolver
{
    /// <summary>
    /// Solves problem 37.
    /// Accepted by LeetCode.
    /// Runtime: 160 ms, faster than 89.30% of C# online submissions (LeetCode submission message).
    /// </summary>
    class SudokuSolver
    {
        static void SolveSudoku(char[][] board)
        {
            Solve();

            bool Solve()
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (board[i][j] == '.')
                        {
                            for (int can = 1; can <= 9; can++)
                            {
                                if (IsValid(i, j, can))
                                {
                                    board[i][j] = can.ToString()[0];

                                    if (Solve())
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        board[i][j] = '.';
                                    }
                                }
                            }

                            return false;
                        }
                    }
                }

                return true;

                bool IsValid(int row, int column, int num)
                {
                    return !IsinRow() && !IsinColumn() && !IsinBox();

                    bool IsinRow()
                    {
                        char cnum = num.ToString()[0];

                        for (int i = 0; i < 9; i++)
                        {
                            if (board[row][i] == cnum)
                            {
                                return true;
                            }
                        }

                        return false;
                    }
                    bool IsinColumn()
                    {
                        char cnum = num.ToString()[0];

                        for (int i = 0; i < 9; i++)
                        {
                            if (board[i][column] == cnum)
                            {
                                return true;
                            }
                        }

                        return false;
                    }
                    bool IsinBox()
                    {
                        char cnum = num.ToString()[0];

                        int r = (row / 3) * 3;
                        int c = (column / 3) * 3;
                        for (int i = r; i < r + 3; i++)
                        {
                            for (int j = c; j < c + 3; j++)
                            {
                                if (board[i][j] == cnum)
                                {
                                    return true;
                                }
                            }
                        }

                        return false;
                    }
                }
            }
        }
    }
}
