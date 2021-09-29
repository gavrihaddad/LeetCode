using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._21___30.Problem27___RemoveElement
{
    /// <summary>
    /// Solves problem 26.
    /// Accepted by LeetCode.
    /// Runtime: 228 ms, faster than 94.92% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class RemoveElement
    {
        public static int RemoveElement1(int[] nums, int val)
        {
            if (Array.FindIndex(nums, item => item == val) == -1)
            {
                return nums.Length;
            }
            else
            {
                int numIndex = 0;
                while (numIndex != -1)
                {
                    int valIndex = Array.FindIndex(nums, item => item == val);
                    numIndex = Array.FindIndex(nums, valIndex, item => item != val);

                    if (numIndex != -1)
                    {
                        nums[valIndex] = nums[numIndex];
                        nums[numIndex] = val;
                    }
                }

                return Array.FindIndex(nums, item => item == val);
            }
        }
    }
}
