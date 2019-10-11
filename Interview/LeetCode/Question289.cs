using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question289
    {
        public static void EntryPoint()
        {
            (new Question289()).GameOfLife(utility.ConvertStringToIntArray("[0,1,0],[0,0,1],[1,1,1],[0,0,0]"));
        }

        public void GameOfLife(int[][] board)
        {
            int[][] temp = new int[board.Length][];
            int[,] directions = new int[,] { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 } };

            for (int i = 0; i < temp.Length; i++)
                temp[i] = new int[board[0].Length];

            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[0].Length; j++)
                    temp[i][j] = board[i][j];

            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[0].Length; j++)
                {
                    int live = 0,
                        dead = 0,
                        x = 0,
                        y = 0;

                    for (int k = 0; k < 8; k++)
                    {
                        x = i + directions[k, 0];
                        y = j + directions[k, 1];

                        if (x > -1 && x < board.Length && y > -1 && y < board[0].Length)
                        {
                            if (temp[x][y] == 1)
                                live++;
                            else
                                dead++;
                        }
                    }

                    if (temp[i][j] == 1)
                    {
                        if (live == 2 || live == 3)
                            board[i][j] = 1;
                        else
                            board[i][j] = 0;
                    }
                    else if (temp[i][j] == 0 && live == 3)
                        board[i][j] = 1;
                }
        }
    }
}
