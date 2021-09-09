using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._41___50.Problem49___GroupAnagrams
{
    /// <summary>
    /// Solves problem 41.
    /// Accepted by LeetCode.
    /// Runtime: 272 ms, faster than 98.82% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class GroupAnagrams
    {
        #region Solution 1: Basic Solution, very simple, very slow.

        // Runtime: 1196 ms, faster than 5.01% of C# online submissions for Group Anagrams.
        public static IList<IList<string>> GetGroupAnagrams1(string[] strs)
        {
            IList<IList<string>> groups = new List<IList<string>>();
            List<string> strsList = strs.ToList();

            while (strsList.Count != 0)
            {
                List<string> group = new List<string>() { strsList[0] };

                for (int i = 1; i < strsList.Count; i++)
                {
                    if (SameLetters(strsList[0], strsList[i]))
                    {
                        group.Add(strsList[i]);
                    }
                }

                foreach (string item in group)
                {
                    strsList.Remove(item);
                }

                groups.Add(group);
            }

            return groups;

            bool SameLetters(string s1, string s2)
            {
                if (s1.Length != s2.Length)
                {
                    return false;
                }
                else
                {
                    foreach (char c in s1)
                    {
                        int index = s2.IndexOf(c);

                        if (index == -1)
                        {
                            return false;
                        }
                        else
                        {
                            s2 = s2.Remove(index, 1);
                        }
                    }

                    return s2.Length == 0;
                }
            }
        }

        #endregion

        #region Solution 2: Based on the Fundamental theorem of arithmetic, fast (272 ms)

        public static IList<IList<string>> GetGroupAnagrams2(string[] strs)
        {
            IList<IList<string>> groups = new List<IList<string>>();
            Dictionary<long, List<string>> groupValues = new Dictionary<long, List<string>>();

            foreach (string str in strs)
            {
                long value = CalculateValue(str);
                if (groupValues.ContainsKey(value))
                {
                    groupValues[value].Add(str);
                }
                else
                {
                    groupValues.Add(value, new List<string>() { str });
                }
            }


            foreach (var str in groupValues)
            {
                groups.Add(str.Value);
            }

            return groups;

            long CalculateValue(string str)
            {
                long value = 1;
                int[] primes = new int[] { 3, 5, 7, 11, 13, 17,
                                           19, 23, 29, 31, 37,
                                           41, 43, 47, 53, 59,
                                           61, 67, 71, 73, 79,
                                           83, 89, 97, 101, 103 };

                foreach (char c in str)
                {
                    value *= primes[c - 'a'];
                }

                return value;
            }
        }

        #endregion
    }
}
