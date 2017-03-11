using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question532
    {
        public static void EntryPoint()
        {
            (new Question532()).FindPairs();
        }

        public int FindPairs(int[] nums, int k)
        {
            int result = 0;
            System.Collections.Hashtable hash = new System.Collections.Hashtable();

            foreach (var item in nums)
                if (hash.ContainsKey(item))
                    hash[item] = (int)hash[item] + 1;
                else
                    hash.Add(item, 1);

            foreach (var item in nums)
            {
                if (hash.ContainsKey(item - k) && (int)hash[item - k] != 0)
                {
                    result++;
                    hash[item - k] = (int)hash[item - k] - 1;
                }

                if (hash.ContainsKey(item + k) && (int)hash[item + k] != 0)
                {
                    result++;
                    hash[item + k] = (int)hash[item + k] - 1;
                }
            }

            return result;
        }
    }
}