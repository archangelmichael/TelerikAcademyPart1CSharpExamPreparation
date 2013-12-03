using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDownWithoutBits
{
    class FallDownWithoutBits
    {
        static void Main(string[] args)
        {
            // solution with bit operations
            //input
            int[,] matrix = new int[8,8];
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
            for (int col = 0; col < 8; col++)
            {
                int count = 0;
                for (int row = 0; row < 8 ; row++)
                {
                    if (matrix [row,col] == 1)
                    {
                        count++;
                        matrix[row, col] = 0;
                    }

                }
                for (int row = 0; row < count; row++)
                {
                        matrix[7-row, col] = 1;
                }
            }
            //output
            for (int row = 0; row < 8; row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < 8; col++)
                {
                    sb.Append(matrix[row,col]);
                }
                int number = Convert.ToInt32(sb.ToString(),2);
                Console.WriteLine(number);
            }
            
        }
    }
}
