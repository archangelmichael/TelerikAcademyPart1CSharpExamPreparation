using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());
            int[,] matrix = new int [number+1, 2*number];

            // solution
            int currentRow = 0;
            int currentCol = 0;
            while (true)
	        {
                if (currentRow == 0 && currentCol == 2* number -1)
                {
                    matrix[currentRow, currentCol] = 1;
                    currentRow++;
                    currentCol = number - 1;
                }
                else if (currentRow== 0 && currentCol < number)
                {
                    currentCol++;
                }
                else if (currentRow == 0 && currentCol >= number && currentCol < 2*number -1)
                {
                    matrix[currentRow, currentCol] = 1;
                    currentCol++;
                }
                else if (currentRow > 0 && currentCol == number - currentRow && currentRow < number)
                {
                    matrix[currentRow, currentCol] = 1;
                    currentCol++;
                }
                else if (currentRow > 0 && currentRow < number && currentCol > number - currentRow && currentCol < 2 * number - 1)
                {
                    currentCol++;
                }
                else if (currentRow > 0 && currentRow < number && currentCol == 2 * number - 1)
                {
                    matrix[currentRow, currentCol] = 1;
                    currentRow++;
                    currentCol = number - currentRow;
                }
                else if (currentRow == number && currentCol < 2* number -1 )
	            {
		            matrix[currentRow, currentCol] = 1;
                    currentCol++;
	            }
                else if (currentRow == number && currentCol == 2*number -1)
                {
                    matrix[currentRow, currentCol] = 1;
                    break;
                }
                
	        }

            //output
            for (int row = 0; row < (number + 1); row++)
			{
			    for (int col = 0; col < 2*number; col++)
			    {
                    
                    if (matrix[row,col] == 0)
                    {
                        Console.Write('.');                        
                    }
                    if (matrix[row,col] == 1)
                    {
                        Console.Write('*');
                    }

			        //Console.Write(matrix[row,col]);
			    }
                Console.WriteLine();
			}
        }
    }
}
