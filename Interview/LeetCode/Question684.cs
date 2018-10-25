using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question684
    {
        public static void EntryPoint()
        {
            int[,] edges = { { 9, 10 }, { 5, 8 }, { 2, 6 }, { 1, 5 }, { 3, 8 }, { 4, 9 }, { 8, 10 }, { 4, 10 }, { 6, 8 }, { 7, 9 } };

            (new Question684()).FindRedundantConnection(edges);
        }

        public int[] FindRedundantConnection(int[,] edges)
        {
            int[] visited = new int[edges.GetLength(0)],
                  result = new int[2];

            for (int i = 0; i < edges.GetLength(0); i++)
            {
                if (visited[edges[i, 0] - 1] == 1 && visited[edges[i, 1] - 1] == 1)
                {
                    result[0] = edges[i, 0];
                    result[1] = edges[i, 1];
                }
                else
                {
                    visited[edges[i, 0]] = 1;
                    visited[edges[i, 1]] = 1;
                }
            }

            return result;
        }
    }
}
