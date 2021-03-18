using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem13___RomanToInteger
{
    /// <summary>
    /// Solves problem 13.
    /// Accepted by LeetCode.
    /// Runtime: 80 ms, faster than 95.95% of C# online submissions (LeetCode submission message).
    /// </summary>
    class RomanToInteger
    {
        static public int RomanToInt(string s)
        {
            Dictionary<char, int> LetterValues = new Dictionary<char, int>();
            Init();

            int result = 0;
            if (s.Length == 1 || LetterValues[s[0]] >= LetterValues[s[1]])
            {
                result = LetterValues[s[0]];
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (LetterValues[s[i + 1]] == LetterValues[s[i]])
                {
                    result += LetterValues[s[i]];
                }
                else if (LetterValues[s[i + 1]] < LetterValues[s[i]])
                {
                    if (i == s.Length - 2)
                    {
                        if (LetterValues[s[i + 1]] > LetterValues[s[i]])
                        {
                            result += LetterValues[s[i + 1]] - LetterValues[s[i]];
                        }
                        else
                        {
                            result += LetterValues[s[i + 1]];
                        }
                    }
                    else if (LetterValues[s[i + 2]] <= LetterValues[s[i + 1]])
                    {
                        result += LetterValues[s[i + 1]];
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    result += LetterValues[s[i + 1]] - LetterValues[s[i]];
                }
            }

            return result;

            void Init()
            {
                LetterValues.Add('M', 1000);
                LetterValues.Add('D', 500);
                LetterValues.Add('C', 100);
                LetterValues.Add('L', 50);
                LetterValues.Add('X', 10);
                LetterValues.Add('V', 5);
                LetterValues.Add('I', 1);
            }
        }
    }
}
