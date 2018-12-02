using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question105
    {
        public static void EntryPoint()
        {
            (new Question105()).BuildTree(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 });
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == inorder ||
                preorder == null || preorder.Length == 0 ||
                inorder == null || inorder.Length == 0)
                return null;

            List<int> preorderList = new List<int>();

            foreach (var item in preorder)
                preorderList.Add(item);

            return Helper(preorderList, inorder);
        }

        private TreeNode Helper(List<int> preorderList, int[] inorder)
        {
            if (inorder.Length == 0)
                return null;

            TreeNode root = new TreeNode(preorderList[0]);
            int index = 0;
            int[] leftInorder = null,
                  rightInorder = null;

            for (; index < inorder.Length && inorder[index] != preorderList[0]; index++) { }

            leftInorder = new int[index];
            Array.Copy(inorder, 0, leftInorder, 0, index);

            if (index > inorder.Length - 1)
                rightInorder = new int[0];
            else
            {
                rightInorder = new int[inorder.Length - index - 1];
                Array.Copy(inorder, index + 1, rightInorder, 0, inorder.Length - index - 1);
            }

            preorderList.RemoveAt(0);

            root.left = Helper(preorderList, leftInorder);
            root.right = Helper(preorderList, rightInorder);

            return root;
        }
    }
}
