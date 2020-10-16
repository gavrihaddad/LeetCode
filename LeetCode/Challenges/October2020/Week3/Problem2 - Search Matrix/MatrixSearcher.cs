using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Challenges.October2020.Week3.Problem2___Search_Matrix
{
    /// <summary>
    /// Solves "Search a 2D Matrix".
    /// October 16 2020.
    /// Accepted by LeetCode.
    /// Runtime: 88 ms, faster than 98.46% of C# online submissions (LeetCode submission details).
    /// </summary>
    static class MatrixSearcher
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            bool found = false;
            int m = matrix.GetLength(0);

            if (m == 0) 
            {
                return false;
            }

            int n = matrix[0].GetLength(0);

            if (n == 0)
            {
                return false;
            }

            int currentStart = 0;
            int currentEnd = m * n - 1;

            while (target >= FindByIndex(currentStart) && target <= FindByIndex(currentEnd))
            {
                int midIndex = (currentStart + currentEnd) / 2;

                if (target > FindByIndex(midIndex)) 
                {
                    currentStart = midIndex + 1;
                    continue;
                }
                if (target < FindByIndex(midIndex))
                {
                    currentEnd = midIndex - 1;
                    continue;
                }

                found = true;
                break;
            }

            return found;

            int FindByIndex(int index)
            {
                return matrix[index / matrix[0].GetLength(0)][index % matrix[0].GetLength(0)];
            }
        }
    }
}
