using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Pillars
    {
        static void Main(string[] args)
        {
            //initialization
            int[,] grid = new int[8, 8];
            bool zero = true;
            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                string numberToString = Convert.ToString(number, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    grid[row, col] = int.Parse(numberToString[col].ToString());
                    if (grid[row, col] == 1)
                    {
                        zero = false;
                    }
                }
            }

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(grid[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            // declare variables

            int result = 0;
            bool win = false;
            byte pil = 0;

            if (zero)
            {
                Console.WriteLine("7");
                Console.WriteLine("0");
                return;
            }
            //solution
            while (pil < 8)
            {
                int left = 0;
                int right = 0;
                for (int j = 0; j < pil; j++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (grid[i, j] == 1)
                        {
                            left++;
                        }
                    }
                }
                if (pil == 7 && left == 0)
                {
                    win = true;
                    break;
                }
                else if( pil == 7)
	            {
                    break;
	            }
                for (int f = pil + 1; f < 8; f++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (grid[i, f] == 1)
                        {
                            right++;
                        }
                    }
                }
                if (left == right)
                {
                    result = left;
                    win = true;
                    break;
                }
                pil++;
            } 
            // output
            if (win)
            {
                Console.WriteLine(7 - pil);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
