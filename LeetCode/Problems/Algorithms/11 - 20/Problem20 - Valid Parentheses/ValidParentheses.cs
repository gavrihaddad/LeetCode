using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._11___20.Problem20___Valid_Parentheses
{
    /// <summary>
    /// Solves problem 20.
    /// Accepted by LeetCode.
    /// </summary>
    public static class ValidParentheses
    {
        /// Runtime: 88 ms.
        public static bool IsValid1(string s)
        {
            Dictionary<char, int> counters = new Dictionary<char, int>
            {
                { '(', 0 },
                { '[', 0 },
                { '{', 0 }
            };
            Dictionary<char, char> matches = new Dictionary<char, char>
            {
                { '(', ')' },
                { ')', '(' },
                { '[', ']' },
                { ']', '[' },
                { '{', '}' },
                { '}', '{' }
            };

            List<char> expectedClosers = new List<char>();

            foreach (char chr in s)
            {
                switch (chr)
                {
                    case '(':
                    case '[':
                    case '{':
                        counters[chr]++;
                        expectedClosers.Add(matches[chr]);
                        break;


                    case ')':
                    case ']':
                    case '}':
                        if (counters[matches[chr]] <= 0 || expectedClosers.Last() != chr)
                        {
                            return false;
                        }
                        counters[matches[chr]]--;
                        expectedClosers.RemoveAt(expectedClosers.Count - 1);
                        break;
                }

            }


            if (counters['('] == 0 && counters['['] == 0 && counters['{'] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// Runtime: 68 ms, faster than 94.78% of C# online submissions (LeetCode submission message).
        public static bool IsValid2(string s)
        {
            Dictionary<char, char> matches = new Dictionary<char, char>
            {
                { '(', ')' },
                { ')', '(' },
                { '[', ']' },
                { ']', '[' },
                { '{', '}' },
                { '}', '{' }
            };

            Stack<char> openers = new Stack<char>();

            foreach (char chr in s)
            {
                switch (chr)
                {
                    case '(':
                    case '[':
                    case '{':
                        openers.Push(chr);
                        break;


                    case ')':
                    case ']':
                    case '}':
                        if (openers.Count == 0 || openers.Peek() != matches[chr])
                        {
                            return false;
                        }
                        openers.Pop();
                        break;
                }

            }


            return openers.Count == 0;
        }
    }
}
