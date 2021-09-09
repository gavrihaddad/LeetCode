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

/*private static string Mult(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
            {
                return "0";
            }
            if (num1.Length < num2.Length)
            {
                string temp = num1;
                num1 = num2;
                num2 = temp;
            }

            List<string> subMults = new List<string>();

            for (int i = num2.Length - 1; i >= 0; i--)
            {
                int carry = 0;
                string subMult = new string('0', num2.Length - 1 - i);
                for (int j = num1.Length - 1; j >= 0; j--)
                {
                    int mult = int.Parse(num2[i].ToString()) * int.Parse(num1[j].ToString());
                    int res = (mult % 10 + carry) % 10;

                    subMult = res.ToString() + subMult;

                    carry = mult / 10 + (mult % 10 + carry) / 10;
                }

                if (carry != 0)
                {
                    subMult = carry + subMult;
                }

                subMults.Add(subMult);
            }

            return SumList(subMults);

            string SumList(List<string> nums)
            {
                if (nums.Count == 1)
                {
                    return nums[0];
                }
                else
                {
                    return Sum(nums[0], SumList(nums.GetRange(1, nums.Count - 1)));
                }
            }

            string Sum(string n1, string n2)
            {
                if (n1.Length < n2.Length)
                {
                    string temp = n1;
                    n1 = n2;
                    n2 = temp;
                }

                while (n2.Length < n1.Length)
                {
                    n2 = '0' + n2;
                }

                int carry = 0;
                string sum = "";
                for (int i = n1.Length - 1; i >= 0; i--)
                {
                    int subSum = int.Parse(n1[i].ToString()) + int.Parse(n2[i].ToString());
                    int res = (subSum % 10 + carry) % 10;

                    sum = res + sum;

                    carry = (subSum + carry) / 10;
                }

                if (carry != 0)
                {
                    sum = carry + sum;
                }

                return sum;
            }
        }*/

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


