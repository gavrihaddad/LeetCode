using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem6___ZigZagConversion
{
    /// <summary>
    /// Solves problem 6.
    /// Accepted by LeetCode.
    /// Runtime: 96 ms, faster than 77.71% of C# online submissions for ZigZag Conversion (LeetCode submission message).
    /// </summary>
    public static class ZigZagConversion
    {
        public static string Convert(string s, int numRows)
        {
            string result = "";
            int jumpSize = GetJumpSize();
            Dictionary<int, int> limits = new Dictionary<int, int>();

            for (int j = 0; j < s.Length; j += jumpSize)
            {
                result += s[j];
                if (j != 0)
                {
                    limits[j - jumpSize] = j;
                }
                limits.Add(j, -1);
            }

            for (int i = 1; i < numRows; i++)
            {
                Dictionary<int, int> newLimits = new Dictionary<int, int>();
                foreach (var part in limits)
                {
                    if (part.Value != -1)
                    {
                        newLimits.Add(part.Key + 1, part.Value - 1);

                        result += s[part.Key + 1];

                        if (part.Value - 1 != part.Key + 1)
                        {
                            result += s[part.Value - 1];
                        }
                    }
                    else
                    {
                        if (part.Key + 1 < s.Length)
                        {
                            result += s[part.Key + 1];
                            newLimits.Add(part.Key + 1, -1);

                            if (part.Key + 1 + jumpSize - 2 * i < s.Length &&
                                part.Key + 1 + jumpSize - 2 * i != part.Key + 1)
                            {
                                result += s[part.Key + 1 + jumpSize - 2 * i];
                            }
                        }
                    }
                }
                limits = newLimits;
            }

            return result;

            int GetJumpSize()
            {
                if (numRows == 1)
                {
                    return 1;
                }
                else
                {
                    return 2 * numRows - 2;
                }
            }
        }

    }
}
