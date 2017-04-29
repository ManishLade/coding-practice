using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;

            int index1 = 0,
                index2 = 1;

            while (index2 <= nums.Length - 1)
                if (nums[index1] == nums[index2])
                    index2++;
                else
                    nums[++index1] = nums[index2++];

            return ++index1;
        }
    }
}