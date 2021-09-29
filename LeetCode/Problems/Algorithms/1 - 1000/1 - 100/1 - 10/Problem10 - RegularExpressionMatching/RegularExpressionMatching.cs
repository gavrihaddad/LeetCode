using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._1___10.Problem10___RegularExpressionMatching
{
    //TODO: finish
    class RegularExpressionMatching
    {
        /*public static bool IsMatch(string s, string p)
        {
            int si = 0;
            int pi = 0;

            while (si < s.Length && pi < p.Length)
            {
                if (pi + 1 < p.Length && p[pi + 1] == '*')
                {
                    int i = 0;
                    while (si + i <= s.Length)
                    {
                        if (p[pi] == '.')
                        {
                            if (IsMatch(s.Substring(si + i), p.Substring(pi + 2)))
                            {
                                return true;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        else
                        {
                            if (IsMatch(s.Substring(si, i), p.Substring(pi, 2)) &&
                                IsMatch(s.Substring(si + i), p.Substring(pi + 2)))
                            {
                                return true;
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                }
                else
                {
                    if (p[pi] == s[si] || p[pi] == '.')
                    {
                        pi++;
                        si++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return pi == p.Length && si == s.Length;
        }*/

        /*public static bool IsMatch(string s, string p)
                {
                    int si = 0;
                    int pi = 0;

                    while (si < s.Length && pi < p.Length)
                    {
                        if (pi + 1 < p.Length && p[pi + 1] == '*')
                        {
                            if (p[pi] == '.')
                            {
                                while (si <= s.Length)
                                {
                                    if (IsMatch(s.Substring(si), p.Substring(pi + 2)))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        si++;
                                    }
                                }
                            }
                            else
                            {
                                (int, int) pcount = CountMinChar(p.Substring(pi));
                                int scount = CountSameChar(s.Substring(si), p[pi]);

                                if (scount >= pcount.Item1)
                                {
                                    si += scount;
                                    pi += pcount.Item2;
                                }
                            }
                        }
                        else
                        {
                            if (p[pi] == s[si] || p[pi] == '.')
                            {
                                pi++;
                                si++;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

                    return pi == p.Length && si == s.Length;

                    (int, int) CountMinChar(string ss)
                    {
                        int count = 0;
                        int index = 0;

                        while (index < ss.Length && ss[index] == ss[0])
                        {
                            if (index + 1 < ss.Length && ss[index + 1] == '*')
                            {
                                index += 2;
                            }
                            else
                            {
                                index++;
                                count++;
                            }
                        }

                        return (count, index);
                    }
                    int CountSameChar(string ss, char c)
                    {
                        if (ss[0] != c)
                        {
                            return 0;
                        }
                        else
                        {
                            int counter = 1;
                            int index = 1;

                            while (index < ss.Length)
                            {
                                if (ss[0] == ss[index])
                                {
                                    counter++;
                                    index++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            return counter;
                        }
                    }
                }*/
    }
}
