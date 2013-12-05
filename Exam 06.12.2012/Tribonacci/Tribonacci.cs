using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            long t1 = long.Parse(Console.ReadLine());
            long t2 = long.Parse(Console.ReadLine());
            long t3 = long.Parse(Console.ReadLine());
            long position = long.Parse(Console.ReadLine());
            BigInteger[] numbers = new BigInteger[position];
            numbers[0] = t1;
            numbers[1] = t2;
            numbers[2] = t3;
            for (int i = 3; i < position; i++)
            {
                numbers[i] = numbers[i-1] + numbers [i-2] + numbers [i- 3];
            }
            Console.WriteLine(numbers[position -1]);
        }
    }
}
