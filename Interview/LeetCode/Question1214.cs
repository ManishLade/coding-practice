using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1214
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool TwoSumBSTs(TreeNode root1, TreeNode root2, int target)
        {
            if (root1 == null)
                return false;

            return FindInTree(root2, target - root1.val) || TwoSumBSTs(root1.left, root2, target) || TwoSumBSTs(root1.right, root2, target);
        }

        public bool FindInTree(TreeNode root, int value)
        {
            if (root == null)
                return false;

            if (root.val == value)
                return true;

            if (root.val < value)
                return FindInTree(root.right, value);
            else
                return FindInTree(root.left, value);
        }
    }
}
