﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem5___LongestPalindromicSubstring
{
    public static class LongestPalindromicSubstring
    {
        //TODO: improve (fix?)
        public static string LongestPalindrome(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    string current = s.Substring(j, s.Length - i);
                    if (IsPalindrome(current))
                    {
                        return current;
                    }
                }
            }

            return result;

            bool IsPalindrome(string str)
            {
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
