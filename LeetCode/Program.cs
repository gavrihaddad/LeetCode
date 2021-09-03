using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
}


//Runtime: 236 ms, faster than 70.77% of C# online submissions for Remove Element.
/*public static int RemoveElement(int[] nums, int val)
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
        }*/