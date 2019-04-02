using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question490
    {
        bool hit = false,
             found = false;

        public bool HasPath(int[][] maze, int[] start, int[] destination)
        {
            int[][] visited = new int[maze.Length][];

            for (int i = 0; i < visited.Length; i++)
                visited[i] = new int[maze[0].Length];

            Helper(maze, visited, start[0], start[1], destination[0], destination[1]);

            return hit;
        }

        private void Helper(int[][] maze, int[][] visited, int currentRow, int currentCol, int destinationRow, int destinationCol)
        {
            bool canNavigate = false;

            if (found)
                return;

            visited[currentRow][currentCol] = 1;

            if (currentRow == destinationRow && currentCol == destinationCol)
                found = true;

            if (currentRow - 1 > -1 && maze[currentRow - 1][currentCol] != 1 && visited[currentRow - 1][currentCol] != 1)
            {
                canNavigate = true;
                Helper(maze, visited, currentRow - 1, currentCol, destinationRow, destinationCol);
            }

            if (currentRow + 1 < maze.Length && maze[currentRow + 1][currentCol] != 1 && visited[currentRow + 1][currentCol] != 1)
            {
                canNavigate = true;
                Helper(maze, visited, currentRow + 1, currentCol, destinationRow, destinationCol);
            }

            if (currentCol - 1 > -1 && maze[currentRow][currentCol - 1] != 1 && visited[currentRow][currentCol - 1] != 1)
            {
                canNavigate = true;
                Helper(maze, visited, currentRow, currentCol - 1, destinationRow, destinationCol);
            }

            if (currentCol + 1 < maze[0].Length && maze[currentRow][currentCol + 1] != 1 && visited[currentRow][currentCol + 1] != 1)
            {
                canNavigate = true;
                Helper(maze, visited, currentRow, currentCol + 1, destinationRow, destinationCol);
            }


            if (!canNavigate && currentRow == destinationRow && currentCol == destinationCol)
                hit = true;
        }
    }
}
