using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DataStructure
{
    // https://www.hackerearth.com/practice/notes/heaps-and-priority-queues/
    class Heap
    {
        private int[] _internalArray { get; set; }

        public Heap(int[] input)
        {
            _internalArray = input;

            BuildMaxHeap(_internalArray, _internalArray.Length - 1);
        }

        private void BuildMaxHeap(int[] input, int end)
        {
            for (int i = (input.Length - 2) / 2; i >= 0; i--)
                Swap(input, i, end);
        }

        private void Swap(int[] input, int currentPosition, int end)
        {
            int largestPosition = 0,
                leftPosition = 2 * currentPosition + 1,
                rightPosition = 2 * currentPosition + 2;

            if (leftPosition <= end && input[currentPosition] < input[leftPosition])
                largestPosition = leftPosition;
            else
                largestPosition = currentPosition;

            if (rightPosition <= end && input[largestPosition] < input[rightPosition])
                largestPosition = rightPosition;

            if (largestPosition != currentPosition)
            {
                int temp = input[largestPosition];
                input[largestPosition] = input[currentPosition];
                input[currentPosition] = temp;

                Swap(input, largestPosition, end);
            }
        }

        public void SortByASC()
        {
            for (int i = (_internalArray.Length - 1); i >= 0; i--)
            {
                int temp = _internalArray[i];
                _internalArray[i] = _internalArray[0];
                _internalArray[0] = temp;

                BuildMaxHeap(_internalArray, (i - 1));
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            foreach (var item in _internalArray)
                output.Append(item.ToString() + " ");

            return output.ToString();
        }
    }
}
