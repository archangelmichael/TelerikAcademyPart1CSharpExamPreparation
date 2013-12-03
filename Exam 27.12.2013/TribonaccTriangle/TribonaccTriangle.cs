using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonaccTriangle
{
    class TribonaccTriangle
    {
        static void Main(string[] args)
        {
            long one = long.Parse(Console.ReadLine());
            long two = long.Parse(Console.ReadLine());
            long three = long.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            long[] numbers = new long [1330];
            
            for (int i = 3; i < 1330; i++)
            {
                numbers[0] = one;
                numbers[1] = two;
                numbers[2] = three;
                numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
            }
            int count = 0;
            for (int i = 1; i <= rows; i++)
            {

                for (int j = count; j < count + i; j++)
                {
                    Console.Write("{0} ", numbers[j]);
                     
                }
                count += i;
                Console.WriteLine();
            }
        }
    }
}
