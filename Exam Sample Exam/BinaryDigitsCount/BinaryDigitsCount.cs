using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            int bit = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            
            int[] counts = new int[n];
            for (int i = 0; i < n; i++)
            {
                long number = long.Parse(Console.ReadLine());

                string numberToString = Convert.ToString(number, 2);
                for (int digit = 0; digit < numberToString.Length; digit++)
                {
                    if (bit == long.Parse(numberToString[digit].ToString()))
                    {
                        counts[i]++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(counts[i]);
            }

            

        }
    }
}
