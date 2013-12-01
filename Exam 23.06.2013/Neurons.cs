using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurons
{
    class Neurons
    {
        static void Main(string[] args)
        {
            int all = 0;
            long[] grid = new long[32];
            
            int counter = 0;
            // initiation of numbers
            do
            {
                grid[counter] = long.Parse(Console.ReadLine());
                if (grid[counter] == -1)
                {
                    all = -1;
                }
                counter++;
            } while (all == 0);

            // print input
            int rows = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i] != -1)
                {
                    //Console.WriteLine("{0}", Convert.ToString(grid[i], 2).PadLeft(32, '0'));
                }
                else
                {
                    rows = i;
                    break;
                }
            }
            long[] neurons = new long[rows];

            //define variables;
            bool top = false;
            bool left = false;
            bool right = false;
            bool bottom = false;
            
            

            // initiate matrix
            int[,] matrix = new int[rows, 32];
            for (int row = 0; row < rows; row++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (grid [row] == -1)
                    {
                        break;
                    }
                    int mask = 1<<j;
                    if ( (grid[row] & mask) != 0 )
                    {
                        matrix[row, 31-j] = 1;
                    }
                }
            }

            // chaking  top, left, right, bottom
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < 32; col++)
                {
                    if (matrix [row,col] == 0)
                    {
                        for (int j = col; j < 31 ; j++)
                        {
                            if (matrix [row,j+1] == 1)
                            {
                                right = true;
                                
                            }
                        }
                        for (int j = col; j >= 1; j--)
                        {
                            if (matrix[ row, j-1] ==1)
                            {
                                left = true;
                                
                            }
                        }
                        for (int j = row; j >= 1; j--)
                        {
                            if (matrix [j-1, col] == 1)
                            {
                                top = true;
                               
                            }
                        }
                        for (int j = row; j < rows-1; j++)
                        {
                            if (matrix [j+1,col] == 1)
                            {
                                bottom = true;
                                
                            }
                        }
                        if (top == true && bottom == true && left == true && right == true)
                        {
                            neurons[row] = neurons[row] | (1 << (31-col));
                        }
                        top = false;
                        right = false;
                        left = false;
                        bottom = false;
                    }
                }
            }

            //print output
            
            for (int i = 0; i < rows; i++)
            {
                if (neurons[i] != -1)
                {
                    Console.WriteLine(neurons[i]);
                    //Console.WriteLine("{0}", Convert.ToString(neurons[i], 2).PadLeft(32, '0'));
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}
