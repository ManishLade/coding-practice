using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question70
    {
        public int ClimbStairs(int n)
        {
            if (n == 0 || n == 1 || n == 2)
                return n;

            int[] array = new int[n + 1];
            array[1] = 1;
            array[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[n];
        }
    }
}