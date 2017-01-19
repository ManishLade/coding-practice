using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question476
    {
        public static void EntryPoint()
        {
            (new Question476()).FindComplement(5);
        }

        public int FindComplement(int num)
        {
            int newNum = 0;

            while (num != 0)
            {
                if ((num & (~num + 1)) == 1)
                    newNum = newNum << 1;
                else
                {
                    newNum++;
                    newNum = newNum << 1;
                }

                num = num >> 1;
            }

            return newNum;
        }
    }
}