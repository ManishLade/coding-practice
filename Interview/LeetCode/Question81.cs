using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question81
    {
        public bool Search(int[] nums, int target)
        {
            int low = 0,
                high = nums.Length - 1,
                middle = low + (high - low) / 2;

            while (low < high)
            {
                if (target < nums[high])
                    low = middle;
                else if (target > nums[low])
                    high = middle;
            }

            return false;
        }
    }
}
