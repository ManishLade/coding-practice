using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1262
    {
        // https://leetcode.com/problems/greatest-sum-divisible-by-three/discuss/431142/Java-O(N)-in-one-pass.
        public int MaxSumDivThree(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int sum = 0;
            int[] modOne = new int[] { Int32.MaxValue, Int32.MaxValue },
                  modTwo = new int[] { Int32.MaxValue, Int32.MaxValue };

            foreach (var num in nums)
            {
                sum += num;

                if (num % 3 == 1)
                    UpdateArray(modOne, num);
                else if (num % 3 == 2)
                    UpdateArray(modTwo, num);
            }

            if (sum % 3 == 0)
                return sum;
            else if (sum % 3 == 1)
            {
                if (modTwo[0] == Int32.MaxValue || modTwo[1] == Int32.MaxValue)
                    return sum - modOne[0];

                return sum - Math.Min(modOne[0], modTwo[0] + modTwo[1]);
            }
            else
            {
                if (modOne[0] == Int32.MaxValue || modOne[1] == Int32.MaxValue)
                    return sum - modTwo[0];

                return sum - Math.Min(modTwo[0], modOne[0] + modOne[1]);
            }
        }

        private void UpdateArray(int[] arr, int num)
        {
            if (num < arr[0])
            {
                arr[1] = arr[0];
                arr[0] = num;
            }
            else if (num < arr[1])
                arr[1] = num;
        }
    }
}
