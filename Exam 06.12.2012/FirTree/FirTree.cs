using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[,] matrix = new int[ number,number* 2 -3];

            int count = 0;
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number * 2 - 3; col++)
                {
                    if (row == number -1)
                    {
                        matrix[row, (number * 2  - 3) / 2] = 1;
                        break;
                    }
                    else if (col >= (number * 2 - 3) / 2 - count && col <= (number * 2 - 3) / 2 + count)
                    {
                        matrix[row,col] = 1;
                    }
                }
                count ++;
                
            }

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number * 2 - 3; col++)
                {
                    if (matrix[row, col] == 0)
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
