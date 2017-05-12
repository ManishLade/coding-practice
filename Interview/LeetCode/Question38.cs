using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question38
    {
        public static void EntryPoint()
        {
            (new Question38()).CountAndSay(4);
        }

        public string CountAndSay(int n)
        {
            int index = 1, resultIndex = 1, count = 1;
            string result = "1", tempResult = string.Empty;
            char currentCharacter = result[0];

            while (index < n)
            {
                while (resultIndex <= result.Length - 1)
                {
                    if (currentCharacter == result[resultIndex])
                        count++;
                    else
                    {
                        tempResult += count.ToString() + currentCharacter;
                        currentCharacter = result[resultIndex];
                        count = 1;
                    }

                    resultIndex++;
                }

                tempResult += count.ToString() + currentCharacter;
                result = tempResult;
                tempResult = string.Empty;
                currentCharacter = result[0];
                resultIndex = 1;
                index++;
            }

            return result;
        }
    }
}