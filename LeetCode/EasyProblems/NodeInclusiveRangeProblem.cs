using LeetCode.Models;

namespace LeetCode.EasyProblems
{
    public class NodeInclusiveRangeProblem
    {
        public NodeInclusiveRangeProblem() { }

        public int InclusiveRange(TreeNode root, int low, int high)
        {
            List<int> nodeValues = new List<int>();
            GetNodeValues(root, nodeValues);
            return(nodeValues.Where(x=> x >= low).Where(x=> x<=high).Sum());
            
        }

        public void GetNodeValues(TreeNode root, List<int> nodeValues)
        {
            if (root == null) return;
            nodeValues.Add(root.val);
            if(root.left != null)
            {
                GetNodeValues(root.left, nodeValues);
            }
            if (root.right != null)
            {
                GetNodeValues(root.right, nodeValues);
            }
        }

    }
}
