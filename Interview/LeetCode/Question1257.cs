using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1257
    {
        public static void EntryPoint()
        {
            IList<IList<string>> regions = new List<IList<string>>();
            regions.Add(new string[] { "Earth", "North America", "South America" }.ToList<string>());
            regions.Add(new string[] { "North America", "United States", "Canada" }.ToList<string>());
            regions.Add(new string[] { "United States", "New York", "Boston" }.ToList<string>());
            regions.Add(new string[] { "Canada", "Ontario", "Quebec" }.ToList<string>());
            regions.Add(new string[] { "South America", "Brazil" }.ToList<string>());

            (new Question1257()).FindSmallestRegion(regions, "Canada", "Quebec");
        }

        // https://leetcode.com/problems/smallest-common-region/discuss/431386/C-Solution-(Short-and-Elegant)
        public string FindSmallestRegion(IList<IList<string>> regions, string region1, string region2)
        {
            string r1 = region1,
                   r2 = region2;
            Dictionary<string, string> dict = new Dictionary<string, string>();

            foreach (var region in regions)
                for (int i = 1; i < region.Count; i++)
                    dict.Add(region[i], region[0]);

            while (r1 != r2)
            {
                r1 = dict.ContainsKey(r1) ? dict[r1] : r1 == string.Empty ? region2 : string.Empty;
                r2 = dict.ContainsKey(r2) ? dict[r2] : r2 == string.Empty ? region1 : string.Empty;
            }

            return r1;
        }
    }
}
