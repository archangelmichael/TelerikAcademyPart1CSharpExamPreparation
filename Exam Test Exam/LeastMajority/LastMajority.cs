using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastMajority
{
    class LastMajority
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int leastMajority = 1;
            int count = 0;
            bool stop = false;
            while (!stop)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (leastMajority % numbers[i] == 0)
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    stop = true;
                }
                else
                {
                    count = 0;
                    leastMajority++;
                }
                
            }
            Console.WriteLine(leastMajority);
            
        }
    }
}
