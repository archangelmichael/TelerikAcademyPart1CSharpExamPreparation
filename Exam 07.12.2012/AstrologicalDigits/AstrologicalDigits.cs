using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (number.Contains('-'))
            {
                number = number.Remove(number.IndexOf('-'), 1); //if (n.Contains('-')) n = n.Remove(0, 1);
            }
            if (number.Contains('.'))
            {
                number = number.Remove(number.IndexOf('.'), 1);
            }
            int sum = 0;
            do
            {
                sum = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    sum += number[i] - 48;
                }
                number = sum.ToString();
            }while(sum>9);
            Console.WriteLine(sum);
        }
    }
}
