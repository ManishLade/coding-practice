using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1209
    {
        public static void EntryPoint()
        {
            (new Question1209()).RemoveDuplicates("deeedbbcccbdaa", 3);
        }

        public string RemoveDuplicates(string s, int k)
        {
            if (s == null || s == string.Empty)
                return s;

            Stack<Tuple<char, int>> stack = new Stack<Tuple<char, int>>();

            foreach (var item in s)
            {
                if (stack.Count > 0 && item == stack.Peek().Item1)
                    stack.Push(new Tuple<char, int>(item, stack.Peek().Item2 + 1));
                else
                    stack.Push(new Tuple<char, int>(item, 1));

                if (stack.Peek().Item2 == k)
                {
                    char current = stack.Peek().Item1;

                    while (stack.Count > 0 && stack.Peek().Item1 == current)
                        stack.Pop();
                }
            }

            if (stack.Count > 0)
            {
                char[] temp = new char[stack.Count];

                for (int i = temp.Length - 1; i > -1; i--)
                    temp[i] = stack.Pop().Item1;

                return new string(temp);
            }
            else
                return string.Empty;
        }
    }
}
