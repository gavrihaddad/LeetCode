using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem7___ReverseInteger
{
    /// <summary>
    /// Solves problem 7.
    /// Accepted by LeetCode.
    ///Runtime: 36 ms, faster than 96.13% of C# online submissions for Reverse Integer. (LeetCode submission message).
    /// </summary>
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            if (x == int.MinValue)
            {
                return 0;
            }

            return Math.Sign(x) * RevertPositive(Math.Abs(x));

            int RevertPositive(int num)
            {
                int res = 0;
                int counter = 1;
                while (num != 0)
                {
                    if (res > int.MaxValue / 10)
                    {
                        return 0;
                    }

                    int lastDigit = num % 10;
                    res *= 10;
                    res += lastDigit;

                    num /= 10;
                    counter++;
                }

                return res;
            }
        }
    }
}
