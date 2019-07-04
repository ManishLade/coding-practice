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
                MaxHeapify(input, i, end);
        }

        private void MaxHeapify(int[] input, int currentPosition, int end)
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

                MaxHeapify(input, largestPosition, end);
            }
        }

        public void SortByASC()
        {
            for (int i = _data.Length - 1; i > 0; i--)
            {
                int temp = _data[i];
                _data[i] = _data[0];
                _data[0] = temp;

                BuildMaxHeap(_data, i - 1);
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

    // This is a MIN heap with the nature of hashtable. What is hash map + heap? Refer the following GitHub repository.
    // https://github.com/mission-peace/interview/blob/259077bacabdbb5b6a0e918cd8dfe5eabca3300f/src/com/interview/graph/BinaryMinHeap.java
    class MinHeap<T>
    {
        private List<Tuple<T, int>> _data = new List<Tuple<T, int>>();
        private Dictionary<T, int> _dictionary = new Dictionary<T, int>();

        public bool Contains(T item)
        {
            return _dictionary.ContainsKey(item);
        }

        public void Add(T item, int weight)
        {

        }

        public void ChangeWeight(T item, int weight)
        {

        }

        public Tuple<T, int> PeekHeapNode()
        {
            return _data.Count != 0 ? _data[0] : null;
        }

        public T PeekKey()
        {
            return PeekHeapNode().Item1;
        }

        public int PeekWeight()
        {
            return PeekHeapNode().Item2;
        }

        public Tuple<T, int> ExtractHeapNode()
        {
            if (_data.Count == 0)
                return null;

            Tuple<T, int> min = _data[0];
            _data[0] = _data[_data.Count - 1];
            _data.RemoveAt(_data.Count - 1);

            MinHeapify(0, _data.Count - 1);

            return min;
        }

        public T ExtractKey()
        {
            return ExtractHeapNode().Item1;
        }

        public int ExtractWeight()
        {
            return ExtractHeapNode().Item2;
        }

        private void MinHeapify(int currentPosition, int end)
        {
            int smallestPosition,
                leftPosition = 2 * currentPosition + 1,
                rightPosition = 2 * currentPosition + 2;
            Tuple<T, int> temp;

            if (leftPosition <= end && _data[currentPosition].Item2 > _data[leftPosition].Item2)
                smallestPosition = leftPosition;
            else
                smallestPosition = currentPosition;

            if (rightPosition <= end && _data[smallestPosition].Item2 > _data[rightPosition].Item2)
                smallestPosition = rightPosition;

            if (smallestPosition != currentPosition)
            {
                temp = _data[smallestPosition];
                _data[smallestPosition] = _data[currentPosition];
                _data[currentPosition] = temp;

                MinHeapify(smallestPosition, end);
            }
        }
    }
}
