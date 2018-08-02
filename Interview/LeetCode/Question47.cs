using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question47
    {
        public static void EntryPoint()
        {
            (new Question47()).PermuteUnique(new int[] { 1, 2, 3 });
        }

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
                Backtrack(nums, i, new List<int>(), result);

            return result;
        }

        private void Backtrack(int[] nums, int currentIndex, List<int> currentCombination, List<IList<int>> result)
        {
            List<int> tempList = new List<int>(currentCombination);

            tempList.Add(nums[currentIndex]);

            if (tempList.Count == nums.Length)
            {
                result.Add(tempList);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
                if (i != currentIndex && !tempList.Contains(nums[i]))
                    Backtrack(nums, i, tempList, result);
        }
    }
}
