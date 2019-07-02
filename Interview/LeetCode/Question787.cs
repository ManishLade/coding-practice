using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.DataStructure;

namespace Interview.LeetCode
{
    class Question787
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
        {
            //int[][] graph = new int[n][];

            //for (int i = 0; i < graph.Length; i++)
            //    graph[i] = new int[n];

            //foreach (int[] flight in flights)
            //    graph[flight[0]][flight[1]] = flight[2];

            //Hashtable best = new Hashtable();

            //PriorityQueue<int[]> pq = new PriorityQueue<int[]>((a, b)->a[0] - b[0]);
            //pq.offer(new int[] { 0, 0, src });

            //while (!pq.isEmpty())
            //{
            //    int[] info = pq.poll();
            //    int cost = info[0], k = info[1], place = info[2];
            //    if (k > K + 1 || cost > best.getOrDefault(k * 1000 + place, Integer.MAX_VALUE))
            //        continue;
            //    if (place == dst)
            //        return cost;

            //    for (int nei = 0; nei < n; ++nei) if (graph[place][nei] > 0)
            //        {
            //            int newcost = cost + graph[place][nei];
            //            if (newcost < best.getOrDefault((k + 1) * 1000 + nei, Integer.MAX_VALUE))
            //            {
            //                pq.offer(new int[] { newcost, k + 1, nei });
            //                best.put((k + 1) * 1000 + nei, newcost);
            //            }
            //        }
            //}

            return -1;
        }

        class Node : IComparable<Node>
        {
            public int v,
                       w,
                       k;

            public Node(int v, int w, int k)
            {
                this.v = v;
                this.w = w;
                this.k = k;
            }

            public int CompareTo(Node o)
            {
                return w.CompareTo(o.w);
            }
        }
    }
}
