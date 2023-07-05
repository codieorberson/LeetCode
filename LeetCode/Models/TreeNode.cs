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
    }
}
