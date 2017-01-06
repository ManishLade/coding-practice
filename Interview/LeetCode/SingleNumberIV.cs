using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class SingleNumberIV
    {
        public static void EntryPoint()
        {
            (new SingleNumberIV()).GetThreeSingle(new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 6 });
        }

        private int[] GetThreeSingle(int[] array)
        {
            int a = 0;

            foreach (var i in array)
                a ^= i;

            foreach (var i in array)
            {

            }

            return null;
        }
    }
}
