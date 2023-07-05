using System.Xml.Linq;
using LeetCode.Models;

namespace LeetCode.MediumProblems
{
    public class DeleteNodesReturnForestProblem
    {
        IList<TreeNode> nodes;
        public DeleteNodesReturnForestProblem()
        {
            nodes = new List<TreeNode>();
        }

        public IList<TreeNode> IsNodesForest(TreeNode root, int[] to_delete)
        {

            if(root != null && !to_delete.Contains(root.val))
                nodes.Add(root);
            CreateDFSNode(root, to_delete);

            return nodes;
        }

        private TreeNode CreateDFSNode(TreeNode node, int[] to_delete)
        {
            if (node == null) return null;

            node.left = CreateDFSNode(node.left, to_delete);
            node.right = CreateDFSNode(node.right, to_delete);

            if (to_delete.Contains(node.val))
            {
                if(node.left != null)
                {
                    nodes.Add(node.left);
                }
                if (node.right != null)
                {
                    nodes.Add(node.right);
                }
                return null;
            }
            return node;
        }
    }
}
