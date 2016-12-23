using System;
using System.Text;

namespace Algorithm.Sort
{
    class HeapSortTest
    {
        public static void Entry()
        {
            int[] input = { 3, 10, 9, 4, 399, 1, 49 };
            //int[] input = { 1, 1, 1, 1, 1 };
            Heap heap = new Heap(input);

            heap.SortByASC();

            Console.WriteLine(heap.ToString());
        }
    }

    // Max-heap
    class Heap
    {
        private int[] InternalArray { get; set; }

        public Heap(int[] input)
        {
            InternalArray = input;
            BuildMaxHeap(InternalArray, InternalArray.Length - 1);
        }

        private void BuildMaxHeap(int[] input, int end)
        {
            for (int i = (input.Length - 2) / 2; i >= 0; i--)
            {
                Swap(input, i, end);
            }
        }

        private void Swap(int[] input, int currentPosition, int end)
        {
            int temp = 0;
            int largestPosition = 0;
            int leftPosition = 2 * currentPosition + 1;
            int rightPosition = 2 * currentPosition + 2;

            if (leftPosition <= end && input[currentPosition] < input[leftPosition])
                largestPosition = leftPosition;
            else
                largestPosition = currentPosition;

            if (rightPosition <= end && input[largestPosition] < input[rightPosition])
                largestPosition = rightPosition;

            if (largestPosition != currentPosition)
            {
                temp = input[largestPosition];
                input[largestPosition] = input[currentPosition];
                input[currentPosition] = temp;

                Swap(input, largestPosition, end);
            }
        }

        public void SortByASC()
        {
            int temp = 0;

            for (int i = (InternalArray.Length - 1); i >= 0; i--)
            {
                temp = InternalArray[i];
                InternalArray[i] = InternalArray[0];
                InternalArray[0] = temp;

                BuildMaxHeap(InternalArray, (i - 1));
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            foreach (var item in InternalArray)
                output.Append(item.ToString() + " ");

            return output.ToString();
        }
    }
}