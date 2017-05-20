using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.Data_Structure;

namespace Interview
{
    class Question94
    {
        public IList<int> InorderTraversal(BinaryTree.Node root)
        {
            List<int> result = new List<int>();

            Traversal(root, result);

            return result;
        }

        private IList<int> Traversal(BinaryTree.Node root, IList<int> list)
        {
            if (root == null)
                return list;

            Traversal(root.LeftNode, list);
            list.Add(root.Value);
            Traversal(root.RightNode, list);

            return list;
        }
    }
}