using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Quadronacci_Rectangle
{
    class QuadronacciRectangle
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());
            BigInteger third = BigInteger.Parse(Console.ReadLine());
            BigInteger fourth = BigInteger.Parse(Console.ReadLine());
            bool start = true;
            BigInteger current = 0;
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            if (cols == 4 && start)
            {
                Console.Write(first + " " + second + " " + third + " " + fourth);
            }
            else if (cols > 4 && start)
            {
                Console.Write(first + " " + second + " " + third + " " + fourth + " ");
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (start)
                    {
                        j = 3;
                        start = false;
                        continue;
                    }
                    current = first + second + third + fourth;
                    if (i == rows -1 && j == cols - 1)
                    {
                        Console.Write(current);
                        break;
                    }
                    else if (j == cols - 1)
                    {
                        Console.Write(current);
                    }
                    else if (j != cols - 1)
                    {
                        Console.Write(current + " ");
                    }
                    first = second;
                    second = third;
                    third = fourth;
                    fourth = current;
                }
                Console.WriteLine();
            }
        }
    }
}
