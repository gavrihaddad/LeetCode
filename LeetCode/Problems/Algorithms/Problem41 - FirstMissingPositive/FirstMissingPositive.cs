using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem41___FirstMissingPositive
{
    /// <summary>
    /// Solves problem 41.
    /// Accepted by LeetCode.
    /// Runtime: 88 ms, faster than 86.71% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class FirstMissingPositive
    {
        public static int GetFirstMissingPositive(int[] nums)
        {
            List<int> positives = new List<int>();

            foreach (int num in nums)
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
                if (positives[i] != ans)
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
        }
    }
}
