using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikLogo
{
    class TelerikLogo
    {
        static void Main(string[] args)
        {
            // inicialization
            int x = int.Parse(Console.ReadLine());
            int y = x;
            int z = x / 2 + 1;
            int width = 2 * x + 2 * z - 3; // or 3*x -2
            int height = 3 * x - 2;  // same as width
            int[,] matrix = new int[height, width];
            //solution
            int currentRow = x / 2;
            int currentCol = 0;
            
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol++;
                currentRow--;
                if (currentRow < 0 )
                {
                    currentRow++;
                    currentCol--;
                    break;
                }
            }
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol++;
                currentRow++;
                if (currentRow == 2*x -1 )
                {
                    currentRow--;
                    currentCol--;
                    break;
                }
            }
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol--;
                currentRow++;
                if (currentRow == width)
                {
                    currentRow--;
                    currentCol++;
                    break;
                }
            }
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol--;
                currentRow--;
                if (currentCol == x/2 -1)
                {
                    currentRow++;
                    currentCol++;
                    break;
                }
            }
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol++;
                currentRow--;
                if (currentRow < 0)
                {
                    currentRow++;
                    currentCol--;
                    break;
                }
            }
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol++;
                currentRow++;
                if (currentCol == width)
                {
                    currentRow--;
                    currentCol--;
                    break;
                }
            }


            // printing
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix [row,col] == 0)
                    {
                        Console.Write('.');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
