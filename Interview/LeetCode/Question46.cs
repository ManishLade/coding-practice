using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question46
    {
        public static void EntryPoint()
        {
            (new Question46()).Permute(new int[] { 1, 2, 3 });
        }

        IList<IList<int>> Permutes = new List<IList<int>>();

        public IList<IList<int>> Permute(int[] nums)
        {
            GetPermute(new List<int>(), nums);

            return Permutes;
        }

        private void GetPermute(List<int> list, int[] nums)
        {
            List<int> tempList = null;

            if (list.Count != nums.Length)
            {
                for (int i = 0; i <= nums.Length - 1; i++)
                {
                    if (!list.Contains(nums[i]))
                    {
                        tempList = new List<int>(list);
                        tempList.Add(nums[i]);
                        GetPermute(tempList, nums);
                    }
                }
            }
            else
                Permutes.Add(list);
        }
    }
}