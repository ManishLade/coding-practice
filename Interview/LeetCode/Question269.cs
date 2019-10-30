using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question269
    {
        public string AlienOrder(string[] words)
        {
            var n = words.Length;
            var longestLength = words.Max(c => c.Length);
            var adjacencyMatrix = new Dictionary<char, HashSet<char>>();
            var indegrees = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (!adjacencyMatrix.ContainsKey(c))
                    {
                        adjacencyMatrix[c] = new HashSet<char>();
                        indegrees[c] = 0;
                    }
                }
            }

            for (int j = 0; j < longestLength; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    var pre = words[i - 1];
                    var cur = words[i];
                    if (j < pre.Length && j < cur.Length && pre.Substring(0, j) == cur.Substring(0, j))
                    {
                        var preWordChar = pre[j - 1 + 1];
                        var curWordChar = cur[j - 1 + 1];

                        if (preWordChar != curWordChar)
                        {
                            if (!adjacencyMatrix[preWordChar].Contains(curWordChar))
                            {
                                indegrees[curWordChar]++;
                                adjacencyMatrix[preWordChar].Add(curWordChar);
                            }
                        }
                    }
                }
            }

            var queue = new Queue<char>();

            foreach (var keyAndValue in indegrees)
            {
                if (keyAndValue.Value == 0)
                {
                    queue.Enqueue(keyAndValue.Key);
                }
            }

            var result = new List<char>();
            while (queue.Any())
            {
                var size = queue.Count;

                for (int s = 0; s < size; s++)
                {
                    var cur = queue.Dequeue();
                    result.Add(cur);

                    foreach (var next in adjacencyMatrix[cur])
                    {
                        indegrees[next]--;
                        if (indegrees[next] == 0)
                        {
                            queue.Enqueue(next);
                        }
                    }
                }
            }

            if (indegrees.Values.Any(c => c != 0))
                return "";

            return string.Join("", result);
        }
    }
}
