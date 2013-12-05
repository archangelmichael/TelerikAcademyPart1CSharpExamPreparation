using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum2
{
    class SubsetSum2
    {
        static void Main(string[] args)
        {
            checked
            {
            long sum = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            // initialization
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            
            long combinations = (long)Math.Pow(2, n) - 1;  // how  many combinations we have
            long sumCounter = 0;

            //solution
            for (int i = 1; i <= combinations; i++)
            {
                
                long tempSum = 0;

                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;
                    /*  bit = (i >> j & 1); */
                    if (bit == 1)
                    {
                        tempSum += numbers[j];
                    }
                }
                if (tempSum == sum)
                {
                    sumCounter++;
                }
            }
            Console.WriteLine(sumCounter);
            }
        }
    }
}
