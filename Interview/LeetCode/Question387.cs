using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question387
    {
        public static void EntryPoint()
        {
            (new Question387()).FirstUniqChar("leetcode");
        }

        public int FirstUniqChar(string s)
        {
            Hashtable hash = new Hashtable();

            for (int i = 0; i <= s.Length - 1; i++)
                if (hash.ContainsKey(s[i]))
                    ((int[])hash[s[i]])[0]++;
                else
                    hash.Add(s[i], new int[] { 1, i });

            foreach (var item in hash.Values)
                if (((int[])item)[0] == 1)
                    return ((int[])item)[1];

            return -1;
        }
    }
}