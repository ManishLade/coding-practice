using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.Data_Structure;

namespace Interview.LeetCode
{
    class Question61
    {
        public Node RotateRight(Node head, int k)
        {
            if (head == null)
                return null;
            else if (k == 0)
                return head;

            Node newHeader = null, tempNode1 = head, tempNode2 = head;
            int index = 1;

            while (index++ <= k + 1)
                if (tempNode2 != null)
                    tempNode2 = tempNode2.NextNode;
                else
                    return head;

            while (tempNode2.NextNode != null)
            {
                tempNode1 = tempNode1.NextNode;
                tempNode2 = tempNode2.NextNode;
            }

            newHeader = tempNode1.NextNode;
            tempNode1.NextNode = null;
            tempNode2.NextNode = head;

            return newHeader;
        }
    }
}