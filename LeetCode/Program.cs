using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] A = new int[6][];
            A[0] = new int[6] { 1, 2, 3, 4, 5, 6 };
            A[1] = new int[6] { 7, 8, 9, 10, 11, 12 };
            A[2] = new int[6] { 13, 14, 15, 16, 17, 18 };
            A[3] = new int[6] { 19, 20, 21, 22, 23, 24 };
            A[4] = new int[6] { 25, 26, 27, 28, 29, 30 };
            A[5] = new int[6] { 31, 32, 33, 34, 35, 36 };

            int[][] B = new int[4][];
            B[0] = new int[4] { 5, 1, 9, 11 };
            B[1] = new int[4] { 2, 4, 8, 10 };
            B[2] = new int[4] { 13, 3, 6, 7 };
            B[3] = new int[4] { 15, 14, 12, 16 };

            int[][] C = new int[1][];
            C[0] = new int[1] { 1 };

            Rotate(C);

            Console.ReadKey();
        }

        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            PrintMatrix();

            for (int round = 0; n > 1; n -= 2, round++) 
            {
                for (int i = 0; i < n - 1; i++)  
                {
                    Index index1 = new Index(round, round + i);
                    Index index2 = new Index(round + i, n + round - 1);
                    Index index3 = new Index(n + round - 1, n + round - i - 1);
                    Index index4 = new Index(n + round - i - 1, round);

                    SwapFour(index1, index2, index3, index4);
                    PrintMatrix();
                }

                Console.WriteLine("round");
            }

            void SwapFour(Index index1, Index index2, Index index3, Index index4)
            {
                int temp = matrix[index4.Row][index4.Column];
                matrix[index4.Row][index4.Column] = matrix[index3.Row][index3.Column];
                matrix[index3.Row][index3.Column] = matrix[index2.Row][index2.Column];
                matrix[index2.Row][index2.Column] = matrix[index1.Row][index1.Column];
                matrix[index1.Row][index1.Column] = temp;
            }

            void PrintMatrix()
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix.Length; j++)
                    {
                        Console.Write(matrix[i][j].ToString() + " ");
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }

    struct Index
    {
        public int Row;
        public int Column;

        public Index(int row, int column)
        {
            Row = row;
            Column = column;
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


