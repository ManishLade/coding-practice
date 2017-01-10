using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.CC150
{
    class CCQuestion917
    {
        public static void EntryPoint()
        {
            Console.WriteLine((new CCQuestion917()).GetMaxSum(new int[] { 2, 3, -8, -1, 2, 4, -2, 3 }));
        }

        public int GetMaxSum(int[] array)
        {
            int sum = 0, maxSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

                if (sum > maxSum)
                    maxSum = sum;
                else if (sum < 0)
                    sum = 0;
            }

            return maxSum;
        }
    }
}