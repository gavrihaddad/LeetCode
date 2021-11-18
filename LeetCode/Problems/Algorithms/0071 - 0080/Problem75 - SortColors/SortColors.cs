using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._0071___0080.Problem75___SortColors
{
    /// <summary>
    /// Solves problem 75.
    /// Accepted by LeetCode.
    /// Runtime: 112 ms, faster than 99.27% of C# online submissions (LeetCode submission message).
    /// </summary>
    class SortColors
    {
        public static void Sort(int[] nums)
        {
            int[] count = new int[3];

            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }

            int index = 0;
            int color = 0;
            foreach (int c in count)
            {
                for (int i = 0; i < c; i++, index++)
                {
                    nums[index] = color;
                }
                color++;
            }
        }
    }
}
