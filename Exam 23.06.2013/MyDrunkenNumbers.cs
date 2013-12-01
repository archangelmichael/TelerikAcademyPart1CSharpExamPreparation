using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrunkenNumbers
{
    class MyDrunkenNumbers
    {
        static void Main(string[] args)
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int drunkenNymberIndex = 0; drunkenNymberIndex < n; drunkenNymberIndex++)
            {
                long absNumber = long.Parse(Console.ReadLine());
                absNumber = Math.Abs(absNumber);
                string input = absNumber.ToString(); //To remove leading zeroes
                //input = input.TrimStart(new char[] { '0', '-' });  second way to remove zeroes

                
                for (int i = 0; i < (input.Length + 1) / 2; i++)
                {
                    int digit = input[i] - '0';     //take the number at possition i before middle
                    leftSum += digit;
                }
                
                for (int i = input.Length / 2; i < input.Length; i++)
                {
                    int digit = input[i] - '0';     //take the number at possition i after middle
                    rightSum += digit;
                }
            }
            if (leftSum>rightSum)
            {
                Console.WriteLine("M " + (leftSum-rightSum));
            }
            else if (rightSum>leftSum)
            {
                Console.WriteLine("V " + (rightSum-leftSum));
            }
            else
            {
                Console.WriteLine("No "+ (leftSum + rightSum));
            }
        }
    }
}
