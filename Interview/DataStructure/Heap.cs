using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DataStructure
{
    // https://www.hackerearth.com/practice/notes/heaps-and-priority-queues/
    class MaxHeap
    {
        private int[] _data { get; set; }

        public MaxHeap(int[] input)
        {
            _data = input;

            BuildMaxHeap(_data, _data.Length - 1);
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
            for (int i = (_data.Length - 1); i >= 0; i--)
            {
                int temp = _data[i];
                _data[i] = _data[0];
                _data[0] = temp;

                BuildMaxHeap(_data, (i - 1));
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            foreach (var item in _data)
                output.Append(item.ToString() + " ");

            return output.ToString();
        }
    }

    // This is a MIN priority queue with the nature of hashtable. What is hash map + heap? Refer the following GitHub repository.
    // https://github.com/mission-peace/interview/blob/259077bacabdbb5b6a0e918cd8dfe5eabca3300f/src/com/interview/graph/BinaryMinHeap.java
    class MinHeap
    {

    }
}
