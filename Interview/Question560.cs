using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Question560
    {
        public static void EntryPoint()
        {
            (new Question560()).SubarraySum(new int[] { 28, 54, 7, -70, 22, 65, -6 }, 100);
        }

        public int SubarraySum(int[] nums, int k)
        {
            int count = 0,
                tempResult = 0;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                tempResult = k;

                for (int j = i; j <= nums.Length - 1; j++)
                {
                    if (nums[j] > tempResult)
                        break;
                    else if (nums[j] < tempResult)
                    {
                        tempResult = tempResult - nums[j];
                        continue;
                    }
                    else
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}