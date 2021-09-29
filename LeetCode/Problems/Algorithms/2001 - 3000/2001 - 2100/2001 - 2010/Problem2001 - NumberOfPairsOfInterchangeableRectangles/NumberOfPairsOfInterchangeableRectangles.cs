using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._2001___3000._2001___2100._2001___2010.Problem2001___NumberOfPairsOfInterchangeableRectangles
{
    /// <summary>
    /// Solves problem 2001.
    /// Accepted by LeetCode.
    /// Runtime: 540 ms, faster than 99.42% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class NumberOfPairsOfInterchangeableRectangles
    {
        public static long InterchangeableRectangles(int[][] rectangles)
        {
            Dictionary<double, long> interchangeables =
                                new Dictionary<double, long>();

            foreach (int[] rect in rectangles)
            {
                double ratio = (double)rect[0] / rect[1];

                if(interchangeables.ContainsKey(ratio))
                {
                    interchangeables[ratio]++;
                }
                else
                {
                    interchangeables.Add(ratio, 1);
                }
            }

            long res = 0;

            foreach(var group in interchangeables)
            {
                if (group.Value > 1)
                {
                    res += ((group.Value * (group.Value - 1)) / 2);
                }
            }

            return res;
        }
    }
}
