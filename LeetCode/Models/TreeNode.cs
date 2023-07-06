namespace LeetCode.Models
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public TreeNode? CreateBinaryTree(int[] nodes, int index = 0)
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

        public bool AreEqual(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null) return true;

            if (node1 == null || node2 == null) return false;

            if (node1.val != node2.val) return false;

            return AreEqual(node1.right, node2.right) && AreEqual(node1.left, node2.left);
        }
    }
}
