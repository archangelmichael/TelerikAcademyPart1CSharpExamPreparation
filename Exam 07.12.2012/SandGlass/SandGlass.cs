using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandGlass
{
    class SandGlass
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            matrix[size / 2+1, size / 2+1] = 1;
            int start = 0;
            int end = size / 2 + 1;
            for (int row = 0; row < size / 2+1; row++)
            {
                for (int col = 0; col < size / 2+1; col++)
                {
                    if (start <= col && col <= end)
                    {
                        matrix[row, col] = 1;
                        matrix[row, size - 1 - col] = 1;
                        matrix[size - 1 - row, col] = 1;
                        matrix[size - 1 - row, size - 1 - col] = 1;
                        
                    }
                }
                start++;
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
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
