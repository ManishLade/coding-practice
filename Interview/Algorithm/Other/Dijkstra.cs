using Interview.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Algorithm.Other
{
    class DijkstraShortestPath
    {
        public static void EntryPoint()
        {
            // Use adjacency list
            // Tuple is graph node. First item is the adjacency node. Second item is the weight between these two nodes.
            //List<Node>[] graph = new List<Node>[6];

            //for (int i = 0; i < 6; i++)
            //    graph[i] = new List<Node>();

            //graph[0].Add(new Tuple<int, int>(1, 5));
            //graph[0].Add(new Tuple<int, int>(3, 9));
            //graph[0].Add(new Tuple<int, int>(4, 2));
            //graph[1].Add(new Tuple<int, int>(2, 2));
            //graph[2].Add(new Tuple<int, int>(3, 3));
            //graph[4].Add(new Tuple<int, int>(5, 3));
            //graph[5].Add(new Tuple<int, int>(3, 2));

            //(new DijkstraShortestPath()).GetShortestPath(graph, 0);
        }

        //public class Node : IComparable<Node>
        //{
        //    public int key = 0,
        //               weight = 0;

        //    public Node(int key, int weight)
        //    {
        //        this.key = key;
        //        this.weight = weight;
        //    }

        //    public int CompareTo(Node other)
        //    {
        //        return this.weight >= other.weight ? 1 : -1;
        //    }
        //}

        //public List<Tuple<int, int>> GetShortestPath(List<Tuple<int, int>>[] graph, int sourceVertex)
        //{

        //    //heap + map data structure
        //    BinaryMinHeap<Vertex<Integer>> minHeap = new BinaryMinHeap<>();

        //    //stores shortest distance from root to every vertex
        //    Map<Vertex<Integer>, Integer> distance = new HashMap<>();

        //    //stores parent of every vertex in shortest distance
        //    Map<Vertex<Integer>, Vertex<Integer>> parent = new HashMap<>();

        //    //initialize all vertex with infinite distance from source vertex
        //    for (Vertex<Integer> vertex : graph.getAllVertex())
        //    {
        //        minHeap.add(Integer.MAX_VALUE, vertex);
        //    }

        //    //set distance of source vertex to 0
        //    minHeap.decrease(sourceVertex, 0);

        //    //put it in map
        //    distance.put(sourceVertex, 0);

        //    //source vertex parent is null
        //    parent.put(sourceVertex, null);

        //    //iterate till heap is not empty
        //    while (!minHeap.empty())
        //    {
        //        //get the min value from heap node which has vertex and distance of that vertex from source vertex.
        //        BinaryMinHeap<Vertex<Integer>>.Node heapNode = minHeap.extractMinNode();
        //        Vertex<Integer> current = heapNode.key;

        //        //update shortest distance of current vertex from source vertex
        //        distance.put(current, heapNode.weight);

        //        //iterate through all edges of current vertex
        //        for (Edge<Integer> edge : current.getEdges())
        //        {

        //            //get the adjacent vertex
        //            Vertex<Integer> adjacent = getVertexForEdge(current, edge);

        //            //if heap does not contain adjacent vertex means adjacent vertex already has shortest distance from source vertex
        //            if (!minHeap.containsData(adjacent))
        //            {
        //                continue;
        //            }

        //            //add distance of current vertex to edge weight to get distance of adjacent vertex from source vertex
        //            //when it goes through current vertex
        //            int newDistance = distance.get(current) + edge.getWeight();

        //            //see if this above calculated distance is less than current distance stored for adjacent vertex from source vertex
        //            if (minHeap.getWeight(adjacent) > newDistance)
        //            {
        //                minHeap.decrease(adjacent, newDistance);
        //                parent.put(adjacent, current);
        //            }
        //        }
        //    }

        //    return distance;
        //}
    }
}
