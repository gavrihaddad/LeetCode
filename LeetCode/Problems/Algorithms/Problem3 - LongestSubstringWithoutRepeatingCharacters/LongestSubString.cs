using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem3___LongestSubstringWithoutRepeatingCharacters
{
    /// <summary>
    /// Solves problem 3.
    /// Accepted by LeetCode.
    /// Runtime: 72 ms, faster than 98.80% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class LongestSubString
    {`
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> mapping = new Dictionary<char, int>(); //Maps chars to their s index.
            int leftBoundary = 0, rightBoundary = 0, result = 0;

            while (rightBoundary < s.Length)
            {
                char charTocheck = s[rightBoundary];

                // If the char was found, we need to move the left boundary to one after it,
                // because as long as it's in the boundries it will be a duplicate.
                // But if the char after it is allready out of the boundries then no change is needed.
                if (mapping.ContainsKey(charTocheck))
                {
                    leftBoundary = Math.Max(mapping[charTocheck] + 1, leftBoundary);
                }

                mapping[charTocheck] = rightBoundary;
                rightBoundary++;
                
                if (rightBoundary - leftBoundary > result) // Changing result when needed.
                {
                    result = rightBoundary - leftBoundary;
                }
            }

            return result;
        }
    }
}