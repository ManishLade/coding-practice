using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1288
    {
        public static void EntryPoint()
        {
            int[][] intervals = new int[3][];
            intervals[0] = new int[] { 2, 10 };
            intervals[1] = new int[] { 3, 8 };
            intervals[2] = new int[] { 4, 7 };

            (new Question1288()).RemoveCoveredIntervals(intervals);
        }

        public int RemoveCoveredIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            int start = intervals[0][0],
                end = intervals[0][1],
                count = 1;

            for (int i = 1; i < intervals.Length; i++)
                if (!IsCovered(intervals[i][0], intervals[i][1], start, end))
                {
                    count++;
                    start = intervals[i][0];
                    end = intervals[i][1];
                }

            return count;
        }

        private bool IsCovered(int a, int b, int c, int d)
        {
            return c <= a && b <= d;
        }
    }
}
