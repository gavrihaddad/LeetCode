using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem9___PalindromeNumber
{
    /// <summary>
    /// Solves problem 9.
    /// Accepted by LeetCode.
    /// Runtime: 52 ms, faster than 97.47% of C# online submissions for Palindrome Number.(LeetCode submission message).
    /// </summary>
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x >= 0)
            {
                int origin = x;
                int rvrsNum = 0;

                while (x > 0)
                {
                    rvrsNum *= 10;
                    rvrsNum += x % 10;
                    x /= 10;
                }

                if (origin == rvrsNum)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
