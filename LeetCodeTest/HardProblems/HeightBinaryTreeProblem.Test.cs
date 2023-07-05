using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.HardProblems;
using LeetCode.Models;

namespace LeetCodeTest.HardProblems
{
    [TestClass]
    public class HeightBinaryTreeProblemTest
    {
        HeightBinaryTreeProblem heightBinaryTreeProblem;

        [TestInitialize]
        public void Setup()
        {
            heightBinaryTreeProblem = new HeightBinaryTreeProblem();
        }

        [TestMethod]
        public void GetHeightWithSubtreeRemoval()
        {
            int[] queries = { 3, 2, 4, 8 };
            int[] nodes = { 5, 8, 9, 2, 1, 3, 7, 4, 6 };
            int[] expected = { 3, 2, 3, 2 };

            TreeNode treeNode = CreateBinaryTree(nodes);
            int[] actual = heightBinaryTreeProblem.GetHeightWithSubtreeRemoval(treeNode, queries);

            CollectionAssert.AreEquivalent(expected, actual);

        }

        private TreeNode? CreateBinaryTree(int[] nodes, int index = 0)
        {
            if (index >= nodes.Length || nodes[index] == 0)
            {
                return null;
            }

            TreeNode node = new TreeNode(nodes[index]);
            node.left = CreateBinaryTree(nodes, 2 * index + 1);
            node.right = CreateBinaryTree(nodes, 2 * index + 2);

            return node;
        }

    }
}
