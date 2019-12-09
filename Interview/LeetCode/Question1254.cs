using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1254
    {
        public static void EntryPoint()
        {
            //int[][] grid = new int[5][];
            //grid[0] = new int[] { 1, 1, 1, 1, 1, 1, 1, 0 };
            //grid[1] = new int[] { 1, 0, 0, 0, 0, 1, 1, 0 };
            //grid[2] = new int[] { 1, 0, 1, 0, 1, 1, 1, 0 };
            //grid[3] = new int[] { 1, 0, 0, 0, 0, 1, 0, 1 };
            //grid[4] = new int[] { 1, 1, 1, 1, 1, 1, 1, 0 };

            //int[][] grid = new int[2][];
            //grid[0] = new int[] { 0, 1 };
            //grid[1] = new int[] { 1, 1 };

            int[][] grid = utility.ConvertStringToIntArray("[0,0,1,1,0,1,0,0,1,0],[1,1,0,1,1,0,1,1,1,0],[1,0,1,1,1,0,0,1,1,0],[0,1,1,0,0,0,0,1,0,1],[0,0,0,0,0,0,1,1,1,0],[0,1,0,1,0,1,0,1,1,1],[1,0,1,0,1,1,0,0,0,1],[1,1,1,1,1,1,0,0,0,0],[1,1,1,0,0,1,0,1,0,1],[1,1,1,0,1,1,0,1,1,0]");

            (new Question1254()).ClosedIsland(grid);
        }

        private int[,] directions = new int[4, 2] { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };

        public int ClosedIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int result = 0;

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == 0 && DFS(grid, i, j))
                        result++;

            return result;
        }

        private bool DFS(int[][] grid, int i, int j)
        {
            bool closed = true;

            grid[i][j] = -1;

            for (int n = 0; n < directions.GetLength(0); n++)
            {
                int x = i + directions[n, 0],
                    y = j + directions[n, 1];

                if (x > -1 && x < grid.Length && y > -1 && y < grid[0].Length)
                {
                    if (grid[x][y] == 1)
                        closed = true && closed;
                    else if (grid[x][y] == 0)
                        closed = DFS(grid, x, y) && closed;
                }
                else
                    closed = false && closed;
            }

            return closed;
        }
    }
}
