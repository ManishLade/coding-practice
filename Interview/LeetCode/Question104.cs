using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.Data_Structure;

namespace Interview.LeetCode
{
    class Question104
    {
        public static void EntryPoint()
        {

        }

        public int MaxDepth(BinaryTree.Node root)
        {
            if (root == null)
                return 0;

            int leftMax = MaxDepth(root.LeftNode);
            int rightMax = MaxDepth(root.RightNode);

            return leftMax >= rightMax ? leftMax + 1 : rightMax + 1;
        }
    }
}