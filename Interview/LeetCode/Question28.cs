using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question28
    {
        public static void EntryPoint()
        {
            (new Question28()).StrStr("hello", "ll");
        }

        public int StrStr(string haystack, string needle)
        {
            int index = -1,
                indexHaystack = 0,
                indexNeedle = 0;
            bool resume = false;

            if (needle != string.Empty && haystack.Length >= needle.Length)
            {
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        indexHaystack = i;
                        indexNeedle = 0;

                        while (indexNeedle < needle.Length && indexHaystack < haystack.Length)
                            if (haystack[indexHaystack++] != needle[indexNeedle++])
                            {
                                resume = true;
                                break;
                            }

                        if (resume)
                            resume = false;
                        else if (indexNeedle == needle.Length)
                        {
                            index = i;
                            break;
                        }
                    }
                }
            }
            else if (haystack.Length < needle.Length)
                index = -1;
            else
                index = 0;

            return index;
        }
    }
}
