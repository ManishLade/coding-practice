using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    // Refer to https://discuss.leetcode.com/topic/71065/just-explain-no-code/2
    class Question400
    {
        public static void EntryPoint()
        {
            Console.WriteLine((new Question400()).FindNthDigit(11));
        }

        public int FindNthDigit(int n)
        {
            if (n <= 9)
                return n;

            long start = 1, count = 9, length = 1, num = 0;

            while (n > count * length)
            {
                n -= (int)(count * length);
                start *= 10;
                count *= 10;
                length += 1;
            }

            num = n / length + start;

            if (n % length == 0)
                return Convert.ToInt32(num.ToString().ToCharArray()[n % length] - '0');
            else
                return Convert.ToInt32(num.ToString().ToCharArray()[n % length - 1] - '0');
        }
    }
}