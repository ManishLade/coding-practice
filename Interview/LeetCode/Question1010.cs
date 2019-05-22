using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1010
    {
        public static void EntryPoint()
        {
            (new Question1010()).NumPairsDivisibleBy60(new int[] { 30, 20, 150, 100, 40 });
        }

        // https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/discuss/296138/Java-solution-from-combination-perspective-with-best-explanation
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
