using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1048
    {
        public int LongestStrChain(string[] words)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            int res = 0;

            Array.Sort(words, (a, b) => a.Length - b.Length);

            foreach (string word in words)
            {
                map[word] = 1;

                for (int i = 0; i < word.Length; i++)
                {
                    StringBuilder sb = new StringBuilder(word);
                    sb.Remove(i, 1);
                    string next = sb.ToString();

                    if (map.ContainsKey(next) && map[next] + 1 > map[word])
                        map[word] = map[next] + 1;
                }

                res = Math.Max(res, map[word]);
            }

            return res;
        }
    }
}
