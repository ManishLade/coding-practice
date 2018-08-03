using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Algorithm.Other
{
    class Mazes
    {
        public static void EntryPoint()
        {
            (new Mazes()).GetPath();
        }

        int[,] mazes = new int[,] { { 10, 1, 0 }, { 0, 0, 0 }, { 1, 1, 11 } };

        public void GetPath()
        {
            PathUtil(0, 0);
        }

        private void PathUtil(int i, int j)
        {            
            if (mazes[i, j] == 11)
                return;

            if (mazes[i, j] != 1)
            {
                if (j + 1 < mazes.GetLength(1))
                    PathUtil(i, j + 1);

                if (i + 1 < mazes.GetLength(0))
                    PathUtil(i + 1, j);
            }
        }
    }
}