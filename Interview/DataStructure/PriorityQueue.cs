using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DataStructure
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data = null;

        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                return data[index];
            }
        }

        public PriorityQueue()
        {
            data = new List<T>();
        }

        public void Enqueue(T item)
        {
            int i = data.Count - 1;

            data.Add(item);

            while (i > 0)
            {
                int m = (i - 1) / 2;

                if (data[i].CompareTo(data[m]) >= 0)
                    break;

                var temp = data[i];
                data[i] = data[m];
                data[m] = temp;

                i = m;
            }
        }

        public T Dequeue()
        {
            int last = data.Count - 1;
            T item = data[0];
            data[0] = data[last];
            data.RemoveAt(last);
            last--;

            int m = 0,
                i = 0;

            while ((i = m * 2 + 1) <= last)
            {
                int r = i + 1;

                if (r <= last && data[r].CompareTo(data[i]) < 0)
                    i = r;

                if (data[m].CompareTo(data[i]) <= 0)
                    break;

                var temp = data[i];
                data[i] = data[m];
                data[m] = temp;

                m = i;
            }

            return item;
        }

        public T Peek()
        {
            return data[0];
        }
    }
}