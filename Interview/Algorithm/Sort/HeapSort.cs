using System;
using System.Text;
using Interview.DataStructure;

namespace Interview.Algorithm.Sort
{
    public class HeapSortTest
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
}