using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question716
    {
        public static void EntryPoint()
        {
            MaxStack obj = new MaxStack();

            obj.Push(-44);
            obj.Top();
            obj.Top();
            obj.Push(63);
            obj.Push(-44);
            obj.PopMax();
            obj.Push(-35);
            obj.PopMax();
            obj.Push(57);
            obj.Push(-88);
            obj.Pop();
            obj.Pop();
            obj.Push(-45);
            obj.PopMax();
            obj.Push(-34);
            obj.PeekMax();
        }
    }

    public class MaxStack
    {
        private SortedList<int, List<int>> _sortedList = new SortedList<int, List<int>>();
        private List<int> _container = new List<int>();

        public MaxStack()
        {

        }

        public void Push(int x)
        {
            _container.Add(x);

            if (!_sortedList.Keys.Contains(x))
                _sortedList.Add(x, new List<int>());

            _sortedList[x].Add(_container.Count - 1);
        }

        public int Pop()
        {
            int result = _container[_container.Count - 1];

            _container.RemoveAt(_container.Count - 1);
            _sortedList[result].RemoveAt(_sortedList[result].Count - 1);

            if (_sortedList[result].Count == 0)
                _sortedList.Remove(result);

            return result;
        }

        public int Top()
        {
            return _container[_container.Count - 1];
        }

        public int PeekMax()
        {
            return _sortedList.Keys.Max();
        }

        public int PopMax()
        {
            int result = _sortedList.Keys.Max(),
                index = 0;

            for (index = _container.Count - 1; index > -1; index--)
                if (_container[index] == result)
                {
                    _container.RemoveAt(index);
                    break;
                }

            _sortedList[result].Remove(index);

            if (_sortedList[result].Count == 0)
                _sortedList.Remove(result);

            return result;
        }
    }
}
