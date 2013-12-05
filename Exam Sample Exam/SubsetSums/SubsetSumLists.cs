using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSumLists
{
    class SubsetSumLists
    {
        static void Main(string[] args)
        {
            
            checked
            {
                
                long s = long.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                long[] numbers = new long[n];
                // initialization
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = long.Parse(Console.ReadLine());
                }

                List<long> sums = new List<long>();
               
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0, len = sums.Count; j < len; j++)
                    {
                        sums.Add(sums[j] + numbers[i]);
                    }
                    sums.Add(numbers[i]);
                }
                int count = 0;
                for (int i = 0; i < sums.Count; i++)
                {
                    if (sums[i] == s)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

                //long combinations = (long)Math.Pow(2, n) - 1;  // how  many combinations we have
                //long sumCounter = 0;

                ////solution
                //for (int i = 1; i <= combinations; i++)
                //{

                //    long tempSum = 0;

                //    for (int j = 0; j < n; j++)
                //    {
                //        int mask = 1 << j;
                //        int iAndMask = mask & i;
                //        int bit = iAndMask >> j;
                //        /*  bit = (i >> j & 1); */
                //        if (bit == 1)
                //        {
                //            tempSum += numbers[j];
                //        }
                //    }
                //    if (tempSum == s)
                //    {
                //        sumCounter++;
                //    }
                //}
                //Console.WriteLine(sumCounter);
            }
            
        }
    }
}
