using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1010
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            int[] c = new int[60];
            int res = 0;

            foreach (var t in time)
            {
                res += c[(60 - t % 60) % 60];
                c[t % 60] += 1;
            }

            return res;
        }
    }
}
