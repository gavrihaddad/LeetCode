using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem14___LongestCommonPrefix
{
    class LongestCommonPrefix
    {
        static public string GetLongestCommonPrefix(string[] strs)
        {
            string prefix = "";

            if (strs.Length > 0)
            {
                for (int i = 0; i < strs[0].Length; i++)
                {
                    char letter = strs[0][i];
                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (strs[j].Length == i || strs[j][i] != letter)
                        {
                            return prefix;
                        }
                    }

                    prefix += letter;
                }
            }

            return prefix;
        }

    }
}
