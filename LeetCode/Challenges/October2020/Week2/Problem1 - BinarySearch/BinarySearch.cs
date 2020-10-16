using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Chalnges.October2020.Week2.Problem1___BinarySearch
{
    /// <summary>
    /// Solves "Serialize and Deserialize BST".
    /// October 8 2020.
    /// Accepted by LeetCode.
    /// Runtime: 124 ms, faster than 96.01% of C# online submissions (LeetCode submission details).
    /// </summary>
    public static class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int result = -1;
            int leftLimit = 0;
            int rightLimit = nums.Length - 1;

            while (leftLimit <= rightLimit)
            {
                int middleIndex = (leftLimit + rightLimit) / 2;

                if(nums[middleIndex] == target)
                {
                    return middleIndex;
                }
                else if (nums[middleIndex] < target)
                {
                    leftLimit = middleIndex + 1;
                }
                else if (nums[middleIndex] > target)
                {
                    rightLimit = middleIndex - 1;
                }
            }

            return result;
        }
    }
}