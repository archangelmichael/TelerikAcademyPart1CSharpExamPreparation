using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Lines
    {
        static void Main()
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
            if (zero)
            {
                Console.WriteLine("8");
                Console.WriteLine("16");
                return;
            }
            int longest = 0;
            int result = 0;
            //solution
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int length = 0;
                    if (grid[i,j] == 1)
                    {
                        length = 1;
                        grid[i, j] = 0;
                        if (i+1<8)
                        {
                            for (int row = i + 1; row < 8; row++)
                            {
                                if (grid[row, j] == 1)
                                {
                                    length++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (length == longest)
                            {
                                result++;
                            }
                            else if (length > longest)
                            {
                                result = 1;
                                longest = length;
                            }
                        }
                        length = 1;
                        
                        if (j+1<8)
                        {
                            for (int cow = j + 1; cow < 8; cow++)
                            {
                                if (grid[i,cow] == 1)
                                {
                                    length++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (length == longest)
                            {
                                result++;
                            }
                            else if( length >longest)
                            {
                                result = 1;
                                longest = length;
                            }
                        }
                    }
                }
            }
            // output
            Console.WriteLine(longest);
            Console.WriteLine(result);
        }
    }
}
