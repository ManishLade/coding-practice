using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question55
    {
        public static void EntryPoint()
        {
            (new Question55()).CanJump(new int[] { 1, 0, 0 });
        }

        public bool CanJump(int[] nums)
        {
            return DFS(nums, 0);
        }

        private bool DFS(int[] nums, int currentIndex)
        {
            if (currentIndex >= nums.Length - 1)
                return true;

            for (int i = 1; i <= nums[currentIndex]; i++)
                return DFS(nums, currentIndex + i);

            return false;
        }
    }
}