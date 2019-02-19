using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question116
    {
        public Node Connect(Node root)
        {
            if (root != null)
            {
                Queue<Node> queue = new Queue<Node>();
                int count = 0;
                Node temp = null;

                queue.Enqueue(root);
                count = queue.Count;

                while (queue.Count > 0)
                {
                    while (count-- > 0)
                    {
                        temp = queue.Dequeue();

                        if (queue.Count > 0 && count > 0)
                            temp.next = queue.Peek();

                        if (temp.left != null)
                            queue.Enqueue(temp.left);

                        if (temp.right != null)
                            queue.Enqueue(temp.right);
                    }

                    count = queue.Count;
                }
            }

            return root;
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }
            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}
