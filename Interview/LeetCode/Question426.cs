using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question426
    {
        public Node TreeToDoublyList(Node root)
        {

        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;

            public Node() { }
            public Node(int _val, Node _left, Node _right)
            {
                val = _val;
                left = _left;
                right = _right;
            }
        }
    }
}
