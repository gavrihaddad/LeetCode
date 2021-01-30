using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem4___MedianOfArrays
{
    /// <summary>
    /// Solves problem 4.
    /// Accepted by LeetCode.
    /// Runtime: 116 ms, faster than 90.73% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class MedianOfArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = new int[nums1.Length + nums2.Length];

            int i = 0, j = 0, k = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    nums[k++] = nums1[i++];
                }
                else
                {
                    nums[k++] = nums2[j++];
                }
            }

            while (i < nums1.Length)
            {
                nums[k++] = nums1[i++];
            }
            while (j < nums2.Length)
            {
                nums[k++] = nums2[j++];
            }

            if (nums.Length % 2 == 0)
            {
                return (double)(nums[nums.Length / 2 - 1] + nums[nums.Length / 2]) / 2;
            }
            else
            {
                return (double)nums[nums.Length / 2];
            }
        }
    }
}