using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1265
    {
        public void PrintLinkedListInReverse(ImmutableListNode head)
        {
            if (head == null)
                return;

            PrintLinkedListInReverse(head.getNext());
            head.printValue();
        }

        public class ImmutableListNode
        {
            public void printValue()
            {

            }

            public ImmutableListNode getNext()
            {
                return null;
            }
        }
    }
}
