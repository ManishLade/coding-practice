using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1239
    {
        public static void EntryPoint()
        {
            List<string> input = new List<string>();
            //input.Add("un");
            //input.Add("iq");
            //input.Add("ue");

            input.Add("yy");
            input.Add("bkhwmpbiisbldzknpm");

            (new Question1239()).MaxLength(input);
        }

        public int MaxLength(IList<string> arr)
        {
            int result = int.MinValue;
            List<List<string>> tempOutput = new List<List<string>>();

            backtrack(arr, 0, new List<string>(), tempOutput);

            foreach (var combination in tempOutput)
            {
                StringBuilder builder = new StringBuilder();
                HashSet<char> hash = new HashSet<char>();

                foreach (var item in combination)
                    builder.Append(item);
                
                foreach (var item in builder.ToString())
                    if (hash.Contains(item))
                        break;
                    else
                        hash.Add(item);

                if (builder.Length == hash.Count)
                    result = Math.Max(hash.Count, result);
            }

            return result == int.MinValue ? 0 : result;
        }

        private void backtrack(IList<string> source, int start, List<string> temp, List<List<string>> result)
        {
            if (temp.Count != 0)
                result.Add(new List<string>(temp));

            for (int i = start; i < source.Count; i++)
            {
                temp.Add(source[i]);
                backtrack(source, i + 1, temp, result);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
