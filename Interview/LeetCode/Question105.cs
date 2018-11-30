using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question105
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == inorder ||
                preorder == null || preorder.Length == 0 ||
                inorder == null || inorder.Length == 0)
                return null;

            if (preorder.Length == 1)
                return new TreeNode(preorder[0]);

            TreeNode root = new TreeNode(preorder[0]),
                     currentNode = root;
            int i = 0,
                j = 0,
                k = 0;

            for (i = 1; i < preorder.Length; i++)
            {
                for (j = 0; j < inorder.Length; j++)
                    if (inorder[j] == preorder[i - 1])
                        break;

                for (k = 0; k < inorder.Length; k++)
                    if (inorder[k] == preorder[i])
                        break;

                if (j > k)
                    currentNode.left = new TreeNode(preorder[i]);
                else
                    currentNode.right = new TreeNode(preorder[i]);                    
            }

            return root;
        }

        private void BuildTree()
        {

        }
    }
}
