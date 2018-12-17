using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question166
    {
        public static void EntryPoint()
        {
            (new Question166()).FractionToDecimal(4, 333);
        }

        public string FractionToDecimal(int numerator, int denominator)
        {
            if (denominator == 0)
                return string.Empty;
            else if (numerator == 0)
                return "0";

            StringBuilder result = new StringBuilder();
            int temp = 0;

            result.Append(numerator / denominator);

            if (numerator % denominator != 0)
            {
                result.Append(".");

                temp = numerator % denominator;

                while (temp != 0)
                {
                    if (temp == numerator && temp * 10 % denominator == 0)
                    {
                        result.Append("(");
                        result.Append(temp * 10 / denominator);
                        result.Append(")");

                        break;
                    }
                    else
                    {
                        result.Append(temp * 10 / denominator);
                        temp = temp * 10 % denominator;
                    }
                }
            }

            return result.ToString();
        }
    }
}
