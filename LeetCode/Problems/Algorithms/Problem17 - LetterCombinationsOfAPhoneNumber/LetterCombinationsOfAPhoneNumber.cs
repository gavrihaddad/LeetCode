using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem17___LetterCombinationsOfAPhoneNumber
{
    /// <summary>
    /// Solves problem 14.
    /// Accepted by LeetCode.
    /// Runtime: 216 ms, faster than 99.81% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class LetterCombinationsOfAPhoneNumber
    {
        private static Dictionary<char, string> digitsLettersMap = new Dictionary<char, string>
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        public static IList<string> LetterCombinations(string digits)
        {
            if (digits == string.Empty)
            {
                return new List<string>();
            }

            var result = new List<string>();
            foreach (var letter in digitsLettersMap[digits[0]])
            {
                IList<string> list = LetterCombinations(digits.Substring(1));
                if (list.Count == 0)
                {
                    result.Add(letter.ToString());
                }
                else
                {
                    foreach (string str in list)
                    {
                        result.Add(letter + str);
                    }
                }
            }

            return result;
        }
    }
}
