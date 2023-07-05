using LeetCode.Models;

namespace LeetCode.HardProblems
{
    public class HeightBinaryTreeProblem
    {
        public HeightBinaryTreeProblem() { }

        public int[] GetHeightWithSubtreeRemoval(TreeNode node, int[] queries)
        {
            List<int> heights = new();
            foreach(int i in queries)
            {
                TreeNode newNode = RemoveNode(node, i);
                heights.Add(GetHeight(newNode) -1);
            }

            return heights.ToArray();
        }

        private TreeNode RemoveNode(TreeNode node, int value)
        {
            if (node == null || node.val == value) return null;

            TreeNode newNode = new TreeNode(node.val);
            newNode.left = RemoveNode(node.left, value);
            newNode.right = RemoveNode(node.right, value);

            return newNode;
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null) return 0;

            int leftTree = GetHeight(node.left);
            int rightTree = GetHeight(node.right);

            return Math.Max(leftTree, rightTree) + 1;
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
