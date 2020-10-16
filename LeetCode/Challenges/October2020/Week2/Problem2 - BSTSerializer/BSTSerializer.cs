using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Chalnges.October2020.Week2.Problem2___BSTSerializer
{
    /// <summary>
    /// Solves "Serialize and Deserialize BST".
    /// October 9 2020.
    /// Accepted by LeetCode.
    /// Runtime: 116 ms, faster than 57.70% of C# online submissions (LeetCode submission details).
    /// </summary>
    public static class BSTSerializer
    {
        /// <summary>
        /// Serializes a tree into a string.
        /// </summary>
        /// <param name="root"> The root of the tree to serialize. </param>
        /// <returns> The string representation of the tree. </returns>
        public static string Serialize(TreeNode root)
        {
            string result = "";

            if(root == null)
            {
                return result;
            }

            result += root.val.ToString() + " ";

            if (root.left != null)
            {
                result += Serialize(root.left);
            }
            if (root.right != null)
            {
                result += Serialize(root.right);
            }

            return result;
        }

        /// <summary>
        /// Deserializes a string representation of a tree back to a tree.
        /// </summary>
        /// <param name="data"> The string representation of the tree. </param>
        /// <returns> The root of the tree. </returns>
        public static TreeNode Deserialize(string data)
        {
            List<int> listData = StringToList(data);
            
            TreeNode root = Deserialize(listData);

            return root;
        }

        /// <summary>
        /// Deserializes a List<int> representation of a tree back to a tree.
        /// </summary>
        /// <param name="data"> The List<int> representation of the tree. </param>
        /// <returns> The root of the tree. </returns>
        private static TreeNode Deserialize(List<int> data)
        {
            if (data.Count == 0)
            {
                return null;
            }

            TreeNode root = new TreeNode(data[0]);

            // Question assumes no duplicate values.
            List<int> leftTreeData = RemoveGreater(data, root.val);   // The left part of the tree only contains numbers smaller than the root.
            List<int> rightTreeData = RemoveSmaller(data, root.val);  // The left part of the tree only contains numbers greater than the root.

            root.left = Deserialize(leftTreeData);
            root.right = Deserialize(rightTreeData);

            return root;
        }

        #region Helpers
        /// <summary>
        /// Turns a string that contains the tree info to an equivalent List<int>.
        /// </summary>
        /// <param name="data"> The tree info in a string format. </param>
        /// <returns> The tree info in a List<int> format. </returns>
        private static List<int> StringToList(string data)
        {
            List<int> result = new List<int>();

            if (data.Length == 0)
            {
                return result;
            }

            data = data.Remove(data.Length - 1); // Remove the last space.

            foreach (string node in data.Split(' '))
            {
                result.Add(int.Parse(node));
            }

            return result;
        }

        /// <summary>
        /// Removes all the items from a given list, that are greater then a given number.
        /// </summary>
        /// <param name="list"> The list to remove from. </param>
        /// <param name="num"> The given number from "summary":) </param>
        /// <returns> The list without the items that are greater then num. </returns>
        private static List<int> RemoveGreater(List<int> list, int num)
        {
            List<int> result = new List<int>();

            foreach (int item in list)
            {
                if (item < num)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        /// <summary>
        /// Removes all the items from a given list, that are smaller then a given number.
        /// </summary>
        /// <param name="list"> The list to remove from. </param>
        /// <param name="num"> The given number from "summary":) </param>
        /// <returns> The list without the items that are smaller then num. </returns>
        private static List<int> RemoveSmaller(List<int> list, int num)
        {
            List<int> result = new List<int>();

            foreach (int item in list)
            {
                if (item > num)
                {
                    result.Add(item);
                }
            }

            return result;
        } 
        #endregion
    }
}