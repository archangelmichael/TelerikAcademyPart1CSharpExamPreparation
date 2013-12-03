using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetsVariant3
{
    class CarpetsVariant3
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[,] matrix = new int[number, number];

            int startSlash = number /2 -1;
            int endSlash = number /2 -1;

            bool isSlash = true;
            for (int row = 0; row < number/2; row++)
            {
                for (int col = 0; col < number/2; col++)
                {
                    if (startSlash <= col && col <= endSlash)
                    {
                        if (isSlash)
                        {
                            matrix[row, col] = 2;
                            matrix[row, number - 1 - col] = 3;
                            matrix[number - 1 - row, col] = 3;
                            matrix[number - 1 - row, number - 1 - col] = 2;
                            isSlash= false;
                        }
                        else 
	                    {
		                    matrix[row, col] = 1;
                            matrix[row, number - 1 - col] = 1;
                            matrix[number - 1 - row, col] = 1;
                            matrix[number - 1 - row, number - 1 - col] = 1;
                            isSlash= true;
	                    }
                    }
                }
                isSlash = true;
                startSlash--;
                
            }

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write(' ');
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
