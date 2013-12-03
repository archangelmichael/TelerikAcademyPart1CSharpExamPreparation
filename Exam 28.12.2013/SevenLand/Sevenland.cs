using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevenland
{
    class Sevenland
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit1 = number%10;
            int digit2 = number / 10 % 10;
            int digit3 = number / 100;
            if (digit1 == 6 && digit2 == 6 && digit3 == 6)
            {
                number = 1000;
            }
            else if (digit1 == 6 && digit2 == 6)
            {
                number = number + 34;
            }
            else if (digit1 == 6)
	        {
		        number += 4;
	        }
            else
	        {
                number  += 1;
	        }
            Console.WriteLine(number);
        }
    }
}
