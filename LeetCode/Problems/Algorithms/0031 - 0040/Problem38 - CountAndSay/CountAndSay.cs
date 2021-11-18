using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._0031___0040.Problem38___CountAndSay
{
    /// <summary>
    /// Solves problem 38.
    /// Accepted by LeetCode.
    // Runtime: 76 ms, faster than 95.14% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class CountAndSay
    {
        public static string GetCountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            else
            {
                string digits = GetCountAndSay(n - 1);

                if (digits.Length == 1)
                {
                    return "1" + digits[0];
                }

                string result = "";

                int count = 1;
                for (int i = 0; i < digits.Length - 1; i++)
                {
                    if (digits[i] == digits[i + 1])
                    {
                        count++;
                        if (i + 1 == digits.Length - 1)
                        {
                            result = result + count.ToString() + digits[i];
                        }
                    }
                    else
                    {
                        result = result + count.ToString() + digits[i];
                        count = 1;
                    }
                }

                if (digits.Last() != digits[digits.Length - 2])
                {
                    result = result + "1" + digits.Last();
                }

                return result;
            }
        }
    }
}
