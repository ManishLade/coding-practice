using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1272
    {
        // https://leetcode.com/problems/remove-interval/solution/
        public IList<IList<int>> RemoveInterval(int[][] intervals, int[] toBeRemoved)
        {
            int removeStart = toBeRemoved[0],
                removeEnd = toBeRemoved[1];
            IList<IList<int>> output = new List<IList<int>>();

            foreach (int[] interval in intervals)
            {
                int start = interval[0],
                    end = interval[1];

                if (end <= removeStart || start >= removeEnd)
                    output.Add(new int[] { start, end }.ToList());
                else if (start < removeStart && end > removeEnd)
                {
                    output.Add(new int[] { start, removeStart }.ToList());
                    output.Add(new int[] { removeEnd, end }.ToList());
                }
                else if (start < removeStart && end <= removeEnd)
                    output.Add(new int[] { start, removeStart }.ToList());
                else if (start >= removeStart && end > removeEnd)
                    output.Add(new int[] { removeEnd, end }.ToList());
            }

            return output;
        }
    }
}
