using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question120
    {
        public static void EntryPoint()
        {
            List<List<int>> triangle = new List<List<int>>();

            List<int> level1 = new List<int>();
            level1.Add(2);
            List<int> level2 = new List<int>();
            level2.Add(3);
            level2.Add(4);
            List<int> level3 = new List<int>();
            level3.Add(6);
            level3.Add(5);
            level3.Add(7);
            List<int> level4 = new List<int>();
            level4.Add(4);
            level4.Add(1);
            level4.Add(8);
            level4.Add(3);

            triangle.Add(level1);
            triangle.Add(level2);
            triangle.Add(level3);
            triangle.Add(level4);

            (new Question120()).MinimumTotal(triangle);
        }

        public int MinimumTotal(List<List<int>> triangle)
        {
            if (triangle == null || triangle.Count == 0)
                return -1;

            int[] results = new int[triangle.Count];
            results[0] = triangle[0][0];

            for (int i = 1; i <= triangle.Count - 1; i++)
            {
                results[i] = int.MaxValue;

                for (int j = 0; j < triangle[i].Count - 1; j++)
                    if (results[i - 1] + triangle[i][j] < results[i])
                        results[i] = results[i - 1] + triangle[i][j];
            }

            return results[triangle.Count - 1];
        }
    }
}