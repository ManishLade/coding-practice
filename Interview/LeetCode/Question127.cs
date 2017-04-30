using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question127
    {
        public static void EntryPoint()
        {
            List<string> input = new List<string>();
            input.Add("hot");
            input.Add("dot");
            input.Add("dog");
            input.Add("lot");
            input.Add("log");
            input.Add("cog");

            (new Question127()).LadderLength("hit", "cog", input);
        }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            int currentAscIISum = GetAscIISum(beginWord),
                endWordASCIISum = GetAscIISum(endWord),
                count = 0;
            Hashtable hash = new Hashtable();
            bool isContinue = false,
                 isFound = false;
            string currentString = beginWord;

            foreach (var item in wordList)
                hash.Add(item, GetAscIISum(item));

            while (hash.Count != 0)
            {
                foreach (var item in hash.Keys)
                {
                    if (Math.Abs((int)hash[item] - currentAscIISum) >= 97 && Math.Abs((int)hash[item] - currentAscIISum) <= 122 && CheckOrder((string)item, currentString))
                    {
                        currentAscIISum = (int)hash[item];
                        currentString = (string)item;
                        hash.Remove(item);

                        if (Math.Abs(endWordASCIISum - currentAscIISum) >= 97 && Math.Abs(endWordASCIISum - currentAscIISum) <= 122 && CheckOrder(currentString, endWord))
                            isFound = true;
                        else
                            isContinue = true;

                        count++;
                        break;
                    }
                }

                if (isContinue)
                {
                    isContinue = false;
                    continue;
                }
                else
                    break;
            }

            return isFound ? count : 0;
        }

        private int GetAscIISum(string input)
        {
            int result = 0;

            foreach (var item in input.ToCharArray())
                result += (int)item;

            return result;
        }

        private bool CheckOrder(string input1, string input2)
        {
            int count = 0;

            for (int i = 0; i <= input1.Length - 1; i++)
                if (input1[i] == input2[i])
                    count++;

            return input1.Length - 1 == count;
        }
    }
}