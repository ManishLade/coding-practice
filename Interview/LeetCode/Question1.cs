using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1
    {
        public static void EntryPoint()
        {

        }

        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null)
                return null;

            Hashtable hash = new Hashtable();
            int[] index = new int[2];

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (hash.ContainsKey(target - nums[i]))
                {
                    index[0] = i;
                    index[1] = (int)hash[target - nums[i]];
                }
                else if (!hash.ContainsKey(nums[i]))
                    hash.Add(nums[i], i);
            }

            return index;
        }
    }
}