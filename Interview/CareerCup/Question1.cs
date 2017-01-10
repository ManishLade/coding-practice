using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.CareerCup
{
    /* https://www.careercup.com/question?id=5163286157852672
    Print an NxM matrix with nw-se diagonals starting at bottom left corner. Ex:

    1  2  3  4
    5  6  7  8
    9 10 11 12

    The output should be:

    9
    5 10
    1 6 11
    2 7 12
    3 8
    4*/
    class CupQuestion1
    {
        public static void EntryPoint()
        {
            (new CupQuestion1()).Print(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } });
        }

        public void Print(int[,] array)
        {
            int minRow = 0, maxRow = array.GetLength(0) - 1,
                minCol = 0, maxCol = array.GetLength(1) - 1,
                startRow = maxRow, startCol = minCol,
                currentRow = startRow, currentCol = startCol;

            do
            {
                do
                {
                    Console.Write(array[currentRow, currentCol] + " ");

                    currentRow++;
                    currentCol++;
                }
                while (currentRow <= maxRow && currentCol <= maxCol) ;

                if (startRow != minRow)
                    startRow--;
                else
                    startCol++;

                currentRow = startRow;
                currentCol = startCol;

                Console.Write("\n");
            }
            while (startRow >= minRow && startCol <= maxCol) ;
        }
    }
}