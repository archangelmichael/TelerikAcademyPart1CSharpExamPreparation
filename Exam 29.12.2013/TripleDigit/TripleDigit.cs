using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleDigit
{
    class TripleDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3 && number > 9; i++)
            {
                int digit = number % 10;
                number = number / 10;

                if (digit != 0)
                {
                    number = (int)(number + digit * Math.Pow(10, number.ToString().Length));
                }
            }

            Console.WriteLine(number);
        }
    }
}
