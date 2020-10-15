using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem1___TowSum
{
    /// <summary>
    /// Solves problem 1.
    /// Accepted by LeetCode.
    /// Runtime: 240 ms, faster than 89.79% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class TowSum
    {
        public static int[] GetTwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> mapping = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int match = target - nums[i];

                if (mapping.ContainsKey(match))
                {
                    result[0] = i;
                    result[1] = mapping[match];

                    break;
                }

                if (mapping.ContainsKey(nums[i]) == false)
                {
                    mapping.Add(nums[i], i);
                }
            }

            return result;
        }
    }
}
