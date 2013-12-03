using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretsVariant2
{
    class SecretsVariant2
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            // If theres is '-' (minus) -> programs removes it
            if (number.Contains('-')) number = number.Remove(number.IndexOf('-'), 1);

            int sumOfDigits = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int position = number.Length - i;
                if (position % 2 != 0)
                {
                    sumOfDigits += (number[i] - 48) * (int)Math.Pow(position, 2);
                }
                else
	            {
                    sumOfDigits += (int)Math.Pow(number[i] - 48, 2) * position;
	            }
            }

            Console.WriteLine(sumOfDigits);

            if (sumOfDigits % 10 == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                for (int i = 0; i < sumOfDigits % 10; i++)
                    Console.Write((char)((sumOfDigits + i) % 26 + 65));

                Console.WriteLine();
            }
        }
    }
}
