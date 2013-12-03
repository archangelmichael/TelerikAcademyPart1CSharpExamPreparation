using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDownWithSorting
{
    class FallDownWithSorting
    {
        static void Main(string[] args)
        {
            // solution with bit operations
            //input
            int[,] matrix = new int[8, 8];
            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                string numberToString = Convert.ToString(number, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = int.Parse(numberToString[col].ToString());
                }
            }
            //solution
            int[] tempMatrix = new int [8];
            for (int col = 0; col < 8; col++)
            {
                
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        tempMatrix[row] = 1;
                    }
                }
                Array.Sort(tempMatrix);  // in beggining the lowest numbers, in the end the biggest
                for (int row = 0; row < 8; row++)
                {
                    matrix[7- row, col] = tempMatrix[7-row];
                    tempMatrix[7-row] = 0;
                }
            }
            //output
            for (int row = 0; row < 8; row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < 8; col++)
                {
                    sb.Append(matrix[row, col]);
                }
                int number = Convert.ToInt32(sb.ToString(), 2);
                Console.WriteLine(number);
            }
        }
    }
}
