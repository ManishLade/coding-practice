using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question168
    {
        public static void EntryPoint()
        {
            (new Question168()).ConvertToTitle(27);
        }

        public string ConvertToTitle(int n)
        {
            int temp = n;
            StringBuilder tempResult = new StringBuilder();
            char[] result = null;

            while (temp != 0)
            {
                tempResult.Append((char)(temp % 27 + 64));
                temp /= 27;
            }

            result = tempResult.ToString().ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }
    }
}