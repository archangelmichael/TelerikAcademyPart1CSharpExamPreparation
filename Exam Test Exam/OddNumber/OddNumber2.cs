using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber2
{
    class OddNumber2
    {
        static void Main(string[] args)
        {
            long count = long.Parse(Console.ReadLine());
            
            int[,] matrix = new int[count,64];

            for (int row = 0; row < count; row++)
            {
                long number = long.Parse(Console.ReadLine());
                string numberToString = Convert.ToString(number, 2).PadLeft(64, '0');
                for (int col = 0; col < 64; col++)
                {
                    matrix[row, col] = int.Parse(numberToString[col].ToString());
                }
            }
            int countzeros = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    for (int j = 0; j < 64; j++)
            //    {
            //        Console.Write(matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}


            string final = ""; //StringBuilder final = new StringBuilder(64);
            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (matrix[j,i] == 0)
                    {
                        countzeros++;
                    }
                }
                if (countzeros % 2 != 0)
                {
                    final += "0";// final.Append("0");
                }
                else
                {
                    final += "1";//final.Append("1");
                }
                countzeros = 0;
                //Console.WriteLine(final);
            }

            long result = Convert.ToInt64(final, 2);
            //long result = Convert.ToInt64(final.ToString(), 2);
            Console.WriteLine(result);
            
        }
    }
}
