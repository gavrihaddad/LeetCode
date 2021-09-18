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

/*
             int[] A1 = new int[] { 1, 2, 3 };
            int[] A2 = new int[] { 3, 9, 0, 1, 4 };
            int[] A3 = new int[] { 2, 3, 1, 1, 4 };
            int[] A4 = new int[] { 1, 2};
            int[] A5 = new int[] { 1 };
            int[] A6 = new int[] { 3, 2, 1 };
            int[] A7 = new int[] { 1, 2, 1, 1, 1 };
            int[] A8 = new int[] { 3, 4, 3, 1, 0, 7, 0, 3, 0, 2, 0, 3 };
            int[] A9 = new int[] { 2, 3, 5, 9, 0, 9, 7, 2, 7, 9, 1, 7, 4, 6, 2, 1, 0, 0, 1, 4, 9, 0, 6, 3 };

            Console.WriteLine(Jump(A1));
            Console.WriteLine(Jump(A2));
            Console.WriteLine(Jump(A3));
            Console.WriteLine(Jump(A4));
            Console.WriteLine(Jump(A5));
            Console.WriteLine(Jump(A6));
            Console.WriteLine(Jump(A7));
            Console.WriteLine(Jump(A8));
            Console.WriteLine(Jump(A9));
 */
/*public static int Jump(int[] nums)
        {
            int[] jumpSizes = new int[nums.Length];
            jumpSizes[nums.Length - 1] = 0;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] == 0)
                {
                    jumpSizes[i] = 10000;
                }
                else if (nums[i] >= nums.Length - i - 1) 
                {
                    jumpSizes[i] = 1;
                }
                else
                {
                    int minJump = jumpSizes[i + 1];
                    for (int j = 1; j < nums[i]; j++)
                    {
                        if (jumpSizes[i + j + 1] < minJump) 
                        {
                            minJump = jumpSizes[i + j + 1];
                        }
                    }

                    jumpSizes[i] = minJump + 1;
                }
            }

            return jumpSizes[0];
        }*/