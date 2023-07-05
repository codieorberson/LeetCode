using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return CreateBinaryTree(rootNodes);
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
