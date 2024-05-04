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

            TreeNode treeNode = new TreeNode().CreateBinaryTree(nodes);
            int[] actual = heightBinaryTreeProblem.GetHeightWithSubtreeRemoval(treeNode, queries);

            CollectionAssert.AreEquivalent(expected, actual);

        }
    }
}
