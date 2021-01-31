using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem8___String_to_Integer__atoi_
{
    public static class StringToInteger
    {
        /// <summary>
        /// Solves problem 8.
        /// Accepted by LeetCode.
        /// Runtime: 68 ms, faster than 97.90% of C# online submissions for String to Integer (atoi). (LeetCode submission message).
        /// </summary>
        public static int MyAtoi(string s)
        {
            int result = 0;
            int sign = 1;
            int currCharIndex = 0;

            while (currCharIndex < s.Length && s[currCharIndex] == ' ')
            {
                currCharIndex++;
            }

            if (currCharIndex < s.Length &&
                (s[currCharIndex] == '+' || s[currCharIndex] == '-'))
                sign = (s[currCharIndex++] == '-') ? -1 : 1;

            while (currCharIndex < s.Length && Digit(s[currCharIndex]) != -1)
            {
                if (result > (int.MaxValue - Digit(s[currCharIndex])) / 10)
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }
                if (result == int.MinValue)
                {
                    return int.MinValue;
                }

                result *= 10;
                result += Digit(s[currCharIndex]);
                currCharIndex++;
            }

            return result *= sign;

            int Digit(char c)
            {
                if (c >= 48 && c <= 57)
                {
                    return int.Parse(c.ToString());
                }

                return -1;
            }
        }

    }
}
