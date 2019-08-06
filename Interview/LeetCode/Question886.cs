using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question886
    {
        public bool PossibleBipartition(int N, int[][] dislikes)
        {
            int[] colors = new int[N + 1];

            for (int i = 1; i <= N; i++)
                colors[i] = i;

            for (int i = 0; i < dislikes.Length; i++)
            {
                int p1 = dislikes[i][0],
                    p2 = dislikes[i][1];

                if (colors[p2] == p2)
                    colors[p2] = p1;
                else
                {
                    int[] uf1 = Find(p1, colors), 
                          uf2 = Find(p2, colors);

                    if (uf1[0] == uf2[0] && uf1[1] == uf2[1])
                        return false;
                }
            }

            return true;
        }

        private int[] Find(int p, int[] colors)
        {
            int color = 0;

            while (colors[p] != p)
            {
                p = colors[p];
                color = color == 0 ? 1 : 0;
            }

            return new int[] { p, color };
        }
    }
}
