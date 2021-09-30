using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms._1___1000._1___100._41___50.Problem46___Permutations
{
    /// <summary>
    /// Solves problem 46.
    /// Accepted by LeetCode.
    /// Runtime: 224 ms, faster than 99.90% of C# online submissions (LeetCode submission message).
    /// </summary>
    public static class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            return MyPermute(nums.ToList());

            IList<IList<int>> MyPermute(List<int> list)
            {
                List<IList<int>> permutations = new List<IList<int>>();

                if (list.Count == 1)
                {
                    permutations.Add(new List<int>() { list[0] });
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        List<int> tempList = new List<int>(list);
                        tempList.RemoveAt(i);

                        var iPermutations = MyPermute(tempList);

                        foreach (var permutation in iPermutations)
                        {
                            permutation.Insert(0, list[i]);
                            permutations.Add(permutation);
                        }
                    }
                }

                return permutations;
            }
        }
    }
}
