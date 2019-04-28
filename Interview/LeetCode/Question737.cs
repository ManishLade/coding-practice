using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question737
    {
        public bool AreSentencesSimilarTwo(string[] words1, string[] words2, string[][] pairs)
        {
            if (words1 == words2 ||
                (words1 == null && words2 != null) ||
                (words1 != null && words2 == null) ||
                words1.Length != words2.Length)
                return false;

            return true;
        }
    }
}
