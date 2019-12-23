using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1258
    {
        public static void EntryPoint()
        {
            IList<IList<string>> synonyms = new List<IList<string>>();
            List<string> list1 = new List<string>(),
                         list2 = new List<string>(),
                         list3 = new List<string>();
            list1.Add("happy");
            list1.Add("joy");
            list2.Add("sad");
            list2.Add("sorrow");
            list3.Add("joy");
            list3.Add("cheerful");
            synonyms.Add(list1);
            synonyms.Add(list2);
            synonyms.Add(list3);

            string text = "I am happy today but was sad yesterday";

            (new Question1258()).GenerateSentences(synonyms, text);
        }

        Dictionary<string, string> parent = new Dictionary<string, string>();

        public IList<string> GenerateSentences(IList<IList<string>> synonyms, string text)
        {
            Dictionary<string, List<string>> unions = new Dictionary<string, List<string>>();
            string[] elements = null;
            Queue<string> queue = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();

            foreach (var item in synonyms)
                Union(item[0], item[1]);

            elements = parent.Keys.ToArray();

            foreach (var item in elements)
            {
                string root = Find(item);

                if (!unions.ContainsKey(root))
                    unions.Add(root, new List<string>());

                unions[root].Add(item);
            }

            queue.Enqueue(text);
            visited.Add(text);

            while (queue.Count != 0)
            {
                string current = queue.Dequeue();

                foreach (var union in unions.Values)
                    foreach (var item in union)
                    {
                        int start = 0,
                            p = 0;

                        while ((p = current.IndexOf(item, start)) != -1)
                        {
                            if ((p == 0 || current[p - 1] == ' ') &&
                                (p + item.Length == current.Length || current[p + item.Length] == ' '))
                            {
                                foreach (var item2 in union)
                                {
                                    string newString = current.Substring(0, p) + item2 + current.Substring(p + item.Length);

                                    if (!visited.Contains(newString))
                                    {
                                        queue.Enqueue(newString);
                                        visited.Add(newString);
                                    }
                                }
                            }

                            start = p + 1;
                        }
                    }
            }

            return visited.ToList().OrderBy(x => x, StringComparer.Ordinal).ToList();
        }

        public string Find(string p)
        {
            if (!parent.ContainsKey(p))
                parent.Add(p, p);
            else if (p != parent[p])
                parent[p] = Find(parent[parent[p]]);

            return parent[p];
        }

        public void Union(string p, string q)
        {
            string unionP = Find(p),
                   unionQ = Find(q);

            if (unionP != unionQ)
                parent[unionP] = unionQ;
        }
    }
}
