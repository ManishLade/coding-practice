using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question89
    {
        public static void EntryPoint()
        {
            (new Question89()).GrayCode(1);
        }

        public IList<int> GrayCode(int n)
        {
            if (n == 0)
                return null;

            byte[] currentCombination = new byte[n];
            Hashtable hash = new Hashtable();

            DFS(currentCombination, hash);

            return null;
        }

        public void DFS (byte[] previousCombination, Hashtable hash)
        {
            hash.Add(previousCombination.GetHashCode(), previousCombination);

            //for (int i = 0; i < previousCombination.Length; i++)
            //{
            //    previousCombination[i] = ~(previousCombination[i]);
            //}
        }
    }
}