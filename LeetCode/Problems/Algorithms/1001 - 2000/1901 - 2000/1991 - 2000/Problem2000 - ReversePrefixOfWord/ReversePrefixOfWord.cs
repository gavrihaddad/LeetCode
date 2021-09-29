using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._1001___2000._1901___2000._1991___2000.Problem2000___ReversePrefixOfWord
{
    /// <summary>
    /// Solves problem 2000.
    /// Accepted by LeetCode.
    /// Runtime: 84 ms, faster than 98.91% of C# online submissions (LeetCode submission message)
    /// </summary>
    public static class ReversePrefixOfWord
    {
        public static string ReversePrefix(string word, char ch)
        {
            string res = "";
            int chi = -1;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    chi = i;
                    break;
                }
            }

            for (int i = chi; i >= 0; i--)
            {
                res += word[i];
            }
            res += word.Substring(chi + 1);

            return res;
        }
    }
}
