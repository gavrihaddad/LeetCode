using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._21___30.Problem26___RemoveDuplicatesFromSortedArray
{
    /// <summary>
    /// Solves problem 26.
    /// Accepted by LeetCode.
    /// </summary>
    public static class RemoveDuplicatesFromSortedArray
    {
        // Runtime: 244 ms, faster than 80.22% of C# online submissions (LeetCode submission message).
        #region Solution 1

        public static int RemoveDuplicates1(int[] nums)
        {
            if (nums.Length == 0) 
            {
                return 0;
            }
            else
            {
                for (int i = 0, j = 1; j < nums.Length; i = j, j++)
                {
                    while (j < nums.Length && nums[i] == nums[j])
                    {
                        nums[j] = -101;
                        j++;
                    }
                }

                if (Array.FindIndex(nums, item => item == -101) == -1) 
                {
                    return nums.Length;
                }
                else
                {
                    int numIndex = 0;
                    while (numIndex != -1)
                    {
                        int dupIndex = Array.FindIndex(nums, item => item == -101);
                        numIndex = Array.FindIndex(nums, dupIndex, item => item != -101);

                        if (numIndex != -1)
                        {
                            nums[dupIndex] = nums[numIndex];
                            nums[numIndex] = -101;
                        }
                    }
                }


                return Array.FindIndex(nums, item => item == -101);
            }
        }

        #endregion

        // Runtime: 232 ms, faster than 98.97% of C# online submissions (LeetCode submission message).
        #region Solution 2

        public static int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else
            {
                int i = 0;
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        i++;
                        nums[i] = nums[j];
                    }
                }

                return i + 1;
            }
        }

        #endregion
    }
}
