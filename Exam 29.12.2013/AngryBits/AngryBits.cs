using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBits
{
    class AngryBits
    {
        static int score = 0;
        static int[,] matrix = new int[8, 16];

        static void Main()
        {
            //input
            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                string numberToString = Convert.ToString(number, 2).PadLeft(16, '0');
                for (int col = 0; col < 16; col++)
                {
                    matrix[row, col] = int.Parse(numberToString[col].ToString());
                }
            }

            //for (int row = 0; row < 8; row++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    for (int col = 0; col < 16; col++)
            //    {
            //        matrix[row, col] = (number >> 15 - col) & 1;
            //    }
            //}
             
            //solution
            for (int col = 7; col >= 0; col--)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        int currentCol = col;
                        int currentRow = row;
                        int path = 0;
                        // fly up
                        while (currentRow > 0)
                        {
                            path++;
                            currentRow--;
                            currentCol++;
                            if (matrix[currentRow, currentCol] == 1)
                            {
                                DestroyPigs(currentRow, currentCol, path);
                                matrix[currentRow, currentCol] = 0;
                                break;
                            }
                        }
                        // fly down       
                        while (currentRow < 7 && currentCol < 15 && matrix[row,col] == 1) 
                        {
                            path++;
                            currentRow++;
                            currentCol++;

                            if (matrix[currentRow, currentCol] == 1)
                            {
                                DestroyPigs(currentRow,currentCol,path);
                                matrix[currentRow, currentCol] = 0;
                                break;
                            }

                            else if (currentRow == 7 || currentCol == 15)
                            {
                                matrix[currentRow, currentCol] = 0;
                                break;
                            }
                        }
                    }
                }
            }
            //output
            bool win = true;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 8; col < 16; col++)
                {
                    if (matrix [row,col] == 1)
                    {
                        win = false;
                    }
                }
            }
            if (win)
            {
                Console.WriteLine(score + " Yes");
            }
            else
	        {
                Console.WriteLine(score + " No");
	        }
        }
        private static void DestroyPigs(int row, int col, int path)
        {
            int tempScore = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (j > 7 && j < 16 && i >= 0 && i < 8)
                    {
                        if (matrix[i, j] == 1)
                        {
                            matrix[i, j] = 0;
                            tempScore++;
                        }
                    }
                }
            }
            score += path * tempScore;
        }
    }
}
