using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question207
    {
        //public bool CanFinish(int numCourses, int[,] prerequisites)
        //{

        //}
    }
    public class CourseGraph
    {
        private int _totalVertex = 0;
        private int[,] _graph = null;
        private bool[] _visited = null;

        public CourseGraph(int numCourses, int[,] prerequisites)
        {
            _graph = new int[numCourses, numCourses];
            _visited = new bool[numCourses];

            for (int i = 0; i < _graph.GetLength(0); i++)
                _graph[prerequisites[i, 0], prerequisites[i, 1]] = 1;
        }


    }
}