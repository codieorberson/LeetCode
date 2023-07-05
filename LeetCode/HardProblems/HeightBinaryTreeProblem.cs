using LeetCode.Models;

namespace LeetCode.HardProblems
{
    public class HeightBinaryTreeProblem
    {
        public HeightBinaryTreeProblem()
        {
        }

        public int[] GetHeightWithSubtreeRemoval(TreeNode node, int[] queries)
        {
            List<int> heights = new();
            foreach (int i in queries)
            {
                TreeNode newRoot = CloneTree(node);
                RemoveNode(ref newRoot, i);
                heights.Add(GetHeight(ref newRoot));
            }
            return heights.ToArray();
        }

        private void RemoveNode(ref TreeNode node, int value)
        {
            if (node == null) return;
            if (node.val == value)
            {
                node = null; // This will remove the node, but will not reattach the children if there are any
            }
            else
            {
                RemoveNode(ref node.left, value);
                RemoveNode(ref node.right, value);
            }
        }

        private int GetHeight(ref TreeNode node)
        {
            if (node == null)
            {
                return -1;
            }
            else
            {
                return 1 + Math.Max(GetHeight(ref node.left), GetHeight(ref node.right));
            }
        }

        public TreeNode CloneTree(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }
            TreeNode newNode = new TreeNode(node.val);
            newNode.left = CloneTree(node.left);
            newNode.right = CloneTree(node.right);
            return newNode;
        }
    }
}
