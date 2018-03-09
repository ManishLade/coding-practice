using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question39
    {
        public static void EntryPoint()
        {
            (new Question39()).CombinationSum(null, 0);
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            SubsetSum(candidates, target, candidates.Length - 1, result);

            return result;
        }

        public void SubsetSum(int[] candidates, int target, int end, IList<IList<int>> result)
        {
            if (target == 0 || end < 0)
                return;

            SubsetSum(candidates, target, end - 1, result);
            SubsetSum(candidates, target - candidates[end], end - 1, result);
        }
    }
}