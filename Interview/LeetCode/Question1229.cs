using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1229
    {
        public static void EntryPoint()
        {
            //int[][] slots1 = new int[1][],
            //        slots2 = new int[1][];
            //slots1[0] = new int[] { 0, 2 };
            //slots2[0] = new int[] { 1, 3 };

            int[][] slots1 = new int[3][],
                    slots2 = new int[2][];
            slots1[0] = new int[] { 10, 50 };
            slots2[1] = new int[] { 60, 120 };
            slots1[2] = new int[] { 140, 210 };
            slots2[0] = new int[] { 0, 15 };
            slots2[1] = new int[] { 60, 70 };

            (new Question1229()).MinAvailableDuration(slots1, slots2, 8);
        }

        public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
        {
            IList<int> result = new List<int>();
            int[][] temp = new int[slots1.Length + slots2.Length][];
            int i = 0,
                j = 0,
                k = 0;

            Array.Sort(slots1, (a, b) => a[0].CompareTo(b[0]));
            Array.Sort(slots2, (a, b) => a[0].CompareTo(b[0]));

            while (i < slots1.Length && j < slots2.Length)
            {
                if (slots1[i][0] <= slots2[j][0])
                {
                    temp[k] = new int[] { slots1[i][0], slots1[i][1] };
                    i++;
                }
                else
                {
                    temp[k] = new int[] { slots2[j][0], slots2[j][1] };
                    j++;
                }

                k++;
            }

            while (i < slots1.Length)
                temp[k++] = new int[] { slots1[i][0], slots1[i++][1] };

            while (j < slots2.Length)
                temp[k++] = new int[] { slots2[j][0], slots2[j++][1] };

            for (i = 0; i < temp.Length - 1; i++)
                if ((temp[i][1] >= temp[i + 1][1] && temp[i + 1][1] - temp[i + 1][0] >= duration) ||
                    (temp[i][1] > temp[i + 1][0] && temp[i][1] < temp[i + 1][1] && temp[i][1] - temp[i + 1][0] >= duration))
                {
                    result.Add(temp[i + 1][0]);
                    result.Add(temp[i + 1][0] + duration);

                    break;
                }

            return result;
        }
    }
}
