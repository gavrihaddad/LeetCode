using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Challenges._2021April.Week4.Problem6___PowerOfThree
{
    //Accepted by LeetCode.
    //Runtime: 64 ms.
    //Your runtime beats 98.16 % of csharp submissions.
    public static class PowerOfThree
    {
        public static bool IsPowerOfThree(int n)
        {
            uint i = 1;
            for (; i < n; i *= 3)
            {

            }

            if (i == n)
            {
                return true;
            }

            return false;
        }
    }
}
