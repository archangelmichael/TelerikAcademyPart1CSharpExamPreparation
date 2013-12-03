using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    class OddNumbers
    {
        static void Main(string[] args)
        {
            long count = long.Parse(Console.ReadLine());
            long oddNumber = 0;
            for (int i = 0; i < count; i++)
            {
                long number = long.Parse(Console.ReadLine());

                oddNumber = oddNumber ^ number;
            }
            Console.WriteLine(oddNumber);
        }
    }
}
