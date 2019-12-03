using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1267
    {
        public static void EntryPoint()
        {
            //int[][] grid = new int[2][];
            //grid[0] = new int[] { 1, 0 };
            //grid[1] = new int[] { 0, 1 };

            int[][] grid = new int[3][];
            grid[0] = new int[] { 1, 0, 0, 1, 0 };
            grid[1] = new int[] { 0, 0, 0, 0, 0 };
            grid[2] = new int[] { 0, 0, 0, 1, 0 };

            (new Question1267()).CountServers(grid);
        }

        private int result = 0;
        private int[,] direction = new int[,] { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };

        public int CountServers(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == 1)
                        DFS(i, j, grid);

            return result;
        }

        private void DFS(int i, int j, int[][] grid)
        {
            for (int n = 0; n < direction.GetLength(0); n++)
            {
                int x = i + direction[n, 0],
                    y = j + direction[n, 1];

                while (x > -1 && x < grid.Length && y > -1 && y < grid[0].Length && grid[x][y] != 1)
                {
                    x += direction[n, 0];
                    y += direction[n, 1];
                }

                if (x > -1 && x < grid.Length && y > -1 && y < grid[0].Length && grid[x][y] == 1)
                {
                    if (grid[i][j] != -1)
                    {
                        grid[i][j] = -1;
                        result++;
                    }

                    result++;
                    grid[x][y] = -1;
                    DFS(x, y, grid);
                }
            }
        }
    }
}
