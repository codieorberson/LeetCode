using LeetCode.MediumProblems;
using LeetCode.Models;

namespace LeetCodeTest.MediumProblems
{
    [TestClass]
    public class DeleteNodesReturnForestProblemTest
    {
        DeleteNodesReturnForestProblem deleteNodesReturnForestProblem;
        [TestInitialize]
        public void Setup() {
            deleteNodesReturnForestProblem = new DeleteNodesReturnForestProblem();
        }

        [TestMethod]
        [DataRow(new int[] {1,2,3,4,5,6,7}, new int[] { 3,5 })]
        public void IsNodesForest(int[] rootNodes, int[] toDeleteNodes)
        {
            TreeNode? treeNode = GenerateTreeNode(rootNodes);
            var actual = deleteNodesReturnForestProblem.IsNodesForest(treeNode, toDeleteNodes);
        }

        private TreeNode? GenerateTreeNode(int[] rootNodes)
        {
            return new TreeNode().CreateBinaryTree(rootNodes);
        }

    }
}
