using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._61___70.Problem62___UniquePaths
{
    /// <summary>
    /// Solves problem 62.
    /// Accepted by LeetCode.
    /// </summary>
    public static class UniquePaths
    {
        //Runtime: 28 ms, faster than 100.00% of C# online submissions (LeetCode submission message).
        #region Solution 1: With partial factorial calculation

        public static int GetUniquePaths1(int m, int n)
        {
            double res = 1;
            int i = m + n - 2;
            for (int j = Math.Max(m - 1, n - 1); j >= 1; i--, j--)
            {
                res *= i;
                res /= j;
            }
            for (int j = Math.Min(m - 1, n - 1); j >= 1; i--, j--)
            {
                res *= i;
                res /= j;
            }

            return res == (int)res ? (int)res : (int)Math.Round(res);
        }

        #endregion


        //Runtime: 36 ms, faster than 91.85% of C# online submissions (LeetCode submission message)
        #region Solution 2: With complete factorial calculation.

        public static int GetUniquePaths2(int m, int n)
        {
            BigInteger a = Factorial(m + n - 2);
            BigInteger b = Factorial(m - 1);
            BigInteger c = Factorial(n - 1);
            return (int)(a / (b * c));

            BigInteger Factorial(int num)
            {
                BigInteger res = 1;

                for (long i = 2; i <= num; i++)
                {
                    res *= i;
                }

                return res;
            }
        }

        #endregion
    }
}
