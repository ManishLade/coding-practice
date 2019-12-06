using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1261
    {
        public class FindElements
        {
            private HashSet<int> set = new HashSet<int>();

            public FindElements(TreeNode root)
            {
                if (root == null)
                    return;

                root.val = 0;

                RecoveryTree(root);
            }

            private void RecoveryTree(TreeNode node)
            {
                set.Add(node.val);

                if (node.left != null)
                {
                    node.left.val = node.val * 2 + 1;
                    RecoveryTree(node.left);
                }

                if (node.right != null)
                {
                    node.right.val = node.val * 2 + 2;
                    RecoveryTree(node.right);
                }
            }

            public bool Find(int target)
            {
                return set.Contains(target);
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
