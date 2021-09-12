using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._41___50.Problem48___RotateImage
{
    /// <summary>
    /// Solves problem 41.
    /// Accepted by LeetCode.
    /// Runtime: 232 ms, faster than 93.14% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            for (int round = 0; n > 1; n -= 2, round++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    Index index1 = new Index(round, round + i);
                    Index index2 = new Index(round + i, n + round - 1);
                    Index index3 = new Index(n + round - 1, n + round - i - 1);
                    Index index4 = new Index(n + round - i - 1, round);

                    SwapFour(index1, index2, index3, index4);
                }
            }

            void SwapFour(Index index1, Index index2, Index index3, Index index4)
            {
                int temp = matrix[index4.Row][index4.Column];
                matrix[index4.Row][index4.Column] = matrix[index3.Row][index3.Column];
                matrix[index3.Row][index3.Column] = matrix[index2.Row][index2.Column];
                matrix[index2.Row][index2.Column] = matrix[index1.Row][index1.Column];
                matrix[index1.Row][index1.Column] = temp;
            }
        }
    }

}
