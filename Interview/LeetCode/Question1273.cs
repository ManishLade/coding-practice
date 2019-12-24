using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interview.LeetCode
{
    class Question1273
    {
        private int RemovedNodes = 0;

        public int DeleteTreeNodes(int nodes, int[] parent, int[] value)
        {
            DFS(0, parent, value);

            return nodes - RemovedNodes;
        }

        private Tuple<int, int> DFS(int currentPosition, int[] parent, int[] value)
        {
            int sumOfAllSubs = 0,
                nodeCount = 1;

            for (int i = currentPosition + 1; i < parent.Length; i++)
                if (parent[i] == currentPosition)
                {
                    Tuple<int, int> subtree = DFS(i, parent, value);

                    sumOfAllSubs += subtree.Item1;
                    nodeCount += subtree.Item2;
                }

            if (value[currentPosition] + sumOfAllSubs == 0 && currentPosition != 0)
            {
                RemovedNodes += nodeCount;
                nodeCount = 0;
            }

            return new Tuple<int, int>(value[currentPosition] + sumOfAllSubs, nodeCount);
        }
    }
}
