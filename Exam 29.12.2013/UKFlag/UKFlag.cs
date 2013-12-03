using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKFlag
{
    class UKFlag
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            matrix[size / 2, size / 2] = 5;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == size/2 && col != size/2)
                    {
                        matrix[row, col] = 4;
                    }
                    else if (row != size/2 && col == size /2)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }
            
            int startSlash = 0;
            int endSlash = size / 2;
            for (int row = 0; row < size / 2; row++)
            {
                for (int col = 0; col < size / 2; col++)
                {
                    if (startSlash <= col && col <= endSlash)
                    {
                            matrix[row, col] = 3;
                            matrix[row, size - 1 - col] = 2;
                            matrix[size - 1 - row, col] = 2;
                            matrix[size - 1 - row, size - 1 - col] = 3;
                            row++;
                    }
                }
                startSlash++;
            }
            
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write('|');
                    }
                    else if (matrix[row, col] == 4)
                    {
                        Console.Write('-');
                    }
                    else if (matrix[row, col] == 5)
                    {
                        Console.Write('*');
                    }
                    else if (matrix[row, col] == 2)
                    {
                        Console.Write('/');
                    }
                    if (matrix[row, col] == 3)
                    {
                        Console.Write('\\');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
