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
            List<int> currentCombination = null;

            for (int i = 0; i < nums.Length; i++)
            {
                currentCombination = new List<int>();

                for (int j = i; j < nums.Length; j++)
                    currentCombination.Add(nums[j]);

                for (int j = 0; j < i; j++)
                    currentCombination.Add(nums[j]);

                result.Add(currentCombination);

                if (i != 0 && i != nums.Length - 1 && nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
                {
                    currentCombination = new List<int>();

                    for (int j = i; j >= 0; j--)
                        currentCombination.Add(nums[j]);

                    for (int j = nums.Length - 1; j > i; j--)
                        currentCombination.Add(nums[j]);

                    result.Add(currentCombination);
                }
            }

            return result;
        }
    }
}
