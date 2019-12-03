using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1268
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            List<IList<string>> result = new List<IList<string>>();
            TrieNode head = new TrieNode();

            Array.Sort(products);

            BuildTrie(head, products);

            foreach (var item in searchWord)
            {
                head = head?.trie[item - 'a'];

                if (head != null)
                    result.Add(head.list.GetRange(0, Math.Min(3, head.list.Count)));
                else
                    result.Add(new List<string>());
            }

            return result;
        }

        private void BuildTrie(TrieNode node, string[] products)
        {
            foreach (var product in products)
            {
                TrieNode currentNode = node;

                foreach (var item in product)
                {
                    if (currentNode.trie[item - 'a'] == null)
                        currentNode.trie[item - 'a'] = new TrieNode();

                    currentNode = currentNode.trie[item - 'a'];
                    currentNode.list.Add(product);
                }
            }
        }

        class TrieNode
        {
            public TrieNode[] trie = new TrieNode[26];
            public List<string> list = new List<string>();
        }
    }
}
