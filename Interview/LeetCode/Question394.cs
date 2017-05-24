using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question394
    {
        public static void EntryPoint()
        {
            (new Question394()).DecodeString("3[a]2[bc]");
        }

        public string DecodeString(string s)
        {
            string result = string.Empty,
                   baseString = string.Empty,
                   temp = string.Empty;
            Stack<char> stack = new Stack<char>();
            int repeatCount = 0;

            foreach (var item in s)
            {
                if (item != ']')
                {
                    stack.Push(item);

                    continue;
                }
                else
                {
                    while (stack.Count != 0 && stack.Peek() != '[')
                        baseString = stack.Pop().ToString() + baseString;

                    stack.Pop();

                    while (stack.Count != 0 && stack.Peek() <= 57)
                        repeatCount = repeatCount * 10 + ((int)stack.Pop() - 48);

                    for (int i = 1; i <= repeatCount; i++)
                        temp += baseString;

                    if (stack.Count == 0)
                    {
                        result += temp;
                        baseString = string.Empty;
                    }
                    else
                    {
                        baseString = temp;
                    }

                    repeatCount = 0;
                }
            }

            return result;
        }
    }
}