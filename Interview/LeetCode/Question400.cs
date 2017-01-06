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
            Console.WriteLine((new Question400()).FindNthDigit(105));
        }

        public int FindNthDigit(int n)
        {
            if (n <= 9)
                return n;

            int start = 1, count = 9, length = 1, num = 0;

            while (n > count * length)
            {
                n -= count * length;
                start *= 10;
                count *= 10;
                length += 1;
            }

            num = n / length + start;

            return Convert.ToInt32(num.ToString().ToCharArray()[n % length - 1] - '0');
        }
    }
}