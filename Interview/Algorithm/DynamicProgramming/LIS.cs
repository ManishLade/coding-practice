using System;

namespace Interview.Algorithm.Other
{
    // *L*ongest *I*ncreasing *S*ubsequence
    class LIS
    {
        public static void EntryPoint()
        {
            int[] input = new int[] { 5, 3, 4, 5, 6, 7 };

            (new LIS()).LengthOfLIS(input);
        }

        private int LengthOfLIS(int[] input)
        {
            if (input == null)
                return 0;
            else if (input.Length == 1)
                return 1;

            int length = 0;
            int[] sequence = new int[input.Length];
            sequence[0] = 1;

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[j] <= input[i])
                    {
                        sequence[i] = sequence[j] + 1;
                        if (length < sequence[i])
                            length = sequence[i];
                    }
                    else
                        sequence[i] = 1;
                }
            }

            return length;
        }

        private void LIS2()
        {
            int LISLength = 0;
            int LISIndex = 0;
            int[] orginalList = new int[] { 2, 1, 5, 3, 6, 4, 8, 9, 7 };
            int[] LIS = new int[9];

            LIS[0] = orginalList[0];
            LISLength++;
            for (int i = 1; i < orginalList.Length; i++)
            {
                LISIndex = GetLISIndex(LIS, LISLength, orginalList[i]);
                if (LISIndex == -1)
                {
                    LIS[LISLength] = orginalList[i];
                    LISLength++;
                }
                else if (LISIndex + 1 >= LISLength)
                {
                    LIS[LISIndex] = orginalList[i];
                    LISLength = LISIndex + 1;
                }
            }

            for (int i = 0; i < LISLength; i++)
            {
                Console.WriteLine(LIS[i]);
            }
        }

        // 折半插入排序
        private static int GetLISIndex(int[] LIS, int LISLength, int currentValue)
        {
            int lowPosition = 0;
            int highPosition = LISLength - 1;
            int lastPosition = 0;

            while (lowPosition <= highPosition)
            {
                if (LIS[(lowPosition + highPosition) / 2] > currentValue)
                {
                    highPosition = (lowPosition + highPosition) / 2 - 1;
                    lastPosition = lowPosition;
                }
                else if (LIS[(lowPosition + highPosition) / 2] < currentValue)
                {
                    lowPosition = (lowPosition + highPosition) / 2 + 1;
                    lastPosition = highPosition;
                }
                else if (LIS[(lowPosition + highPosition) / 2] == currentValue)
                    return (lowPosition + highPosition) / 2;
            }

            if (LIS[lastPosition] > currentValue)
                return lastPosition;
            else
                return -1;
        }
    }
}