using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Secrets
{
    class Secrets
    {
        static void Main(string[] args)
        {
            
            BigInteger number = 0;
            number = BigInteger.Parse(Console.ReadLine());
            if (number < 0)
            {
                number *= (-1);
            }
            BigInteger specialSum = 0;
            BigInteger digit;
            int position = 1;
            BigInteger numberClone = number;
            do
            {
                digit =  number % 10;
                if (position % 2 != 0)
                {
                    specialSum = specialSum + (digit * position * position);
                }
                
                else
	            {
                    specialSum = specialSum + (digit * digit * position); 
	            }
                number = number / 10;
                ++position;
            } while (number > 0 );
            Console.WriteLine(specialSum);
            digit =  specialSum % 10;
            
            if (digit == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", numberClone);
            }
            else
            {
                int remainder = (int) specialSum % 26;
                for (int i = 0; i < digit; i++)
                {
                    if (remainder >= 26)
                    {
                        remainder = remainder - 26;
                    }
                    Console.Write("{0}", Convert.ToChar(64+remainder+1));
                    remainder++;
                    
                }
            }
            Console.WriteLine();
            
        }
    }
}
