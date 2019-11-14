using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1215
    {
        public IList<int> CountSteppingNumbers(int low, int high)
        {
            List<int> result = new List<int>();
            LinkedList<long> bfs = new LinkedList<long>();

            bfs.AddLast(0);
            bfs.AddLast(1);
            bfs.AddLast(2);
            bfs.AddLast(3);
            bfs.AddLast(4);
            bfs.AddLast(5);
            bfs.AddLast(6);
            bfs.AddLast(7);
            bfs.AddLast(8);
            bfs.AddLast(9);

            while (bfs.Count > 0)
            {
                long current = bfs.First.Value,
                     lastDigit = current % 10,
                     nextL = current * 10 + (lastDigit - 1),
                     nextH = current * 10 + (lastDigit + 1);

                bfs.RemoveFirst();

                if (current <= high && current >= low)
                    result.Add((int)current);

                if (current == 0 || current > high)
                    continue;

                if (lastDigit == 0)
                    bfs.AddLast(nextH);
                else if (lastDigit == 9)
                    bfs.AddLast(nextL);
                else
                {
                    bfs.AddLast(nextL);
                    bfs.AddLast(nextH);
                }
            }

            return result;
        }
    }
}
