using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question278
    {
        public int FirstBadVersion(int n)
        {
            if (n == 0)
                return n;

            int start = 1, mid = 0, end = n;

            while (start < end)
            {
                mid = start + (end - start) / 2;

                if (!IsBadVersion(mid))
                    start = mid + 1;
                else
                    end = mid;
            }

            return start;
        }

        private bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
        }
    }
}