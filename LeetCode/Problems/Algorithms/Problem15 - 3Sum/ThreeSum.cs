using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem15___3Sum
{
    public static class ThreeSum
    {
        static public IList<IList<int>> GetThreeSum(int[] nums)
        {
            IList<IList<int>> answer = new List<IList<int>>();

            List<int> numsList = new List<int>(nums);
            numsList.Sort();

            for (int i = 0; i < numsList.Count - 2; i++)
            {
                if (numsList[i] > 0)
                {
                    break;
                }
                if (i >= 1 && numsList[i] == numsList[i - 1])
                {
                    continue;
                }

                int j = i + 1, k = numsList.Count - 1;

                while (j < k)
                {
                    if (numsList[j] + numsList[k] == 0 - numsList[i])
                    {
                        answer.Add(new List<int> { numsList[i], numsList[j], numsList[k] });
                        j++;
                        k--;

                        while (j < numsList.Count && numsList[j] == numsList[j - 1])
                        {
                            j++;
                        }
                        while (k > j && numsList[k] == numsList[k + 1])
                        {
                            k--;
                        }
                    }
                    else if (numsList[j] + numsList[k] > 0 - numsList[i])
                    {
                        k--;
                        while (k > j && numsList[k] == numsList[k + 1])
                        {
                            k--;
                        }
                    }
                    else
                    {
                        j++;
                        while (j < k && numsList[j] == numsList[j - 1])
                        {
                            j++;
                        }
                    }
                }
            }

            return answer;
        }
    }
}
