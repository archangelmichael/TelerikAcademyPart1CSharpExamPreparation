using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesBitwise
{
    class LinesBitwise
    {
        static void Main()
        {
            int n = 8;
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    int bit = (number >> j) & 1;
                    matrix[i, j] = bit;
                }
            }
            int longest = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int current = 0;
                for (int j = 0; j < n; j++)
                {
                    while (j < n && matrix[i, j] == 1)
                    {
                        current++;
                        j++;
                    }
                    if (current > longest)
                    {
                        longest = current;
                        result = 1;
                    }
                    else if (longest == current)
                    {
                        result++;
                    }
                    current = 0;
                }
            }
            for (int j = 0; j < n; j++)
            {
                int current = 0;
                for (int i = 0; i < n; i++)
                {
                    while (i < n && matrix[i, j] == 1)
                    {
                        current++;
                        i++;
                    }
                    if (current > longest)
                    {
                        longest = current;
                        result = 1;
                    }
                    else if (longest == current)
                    {
                        result++;
                    }
                    current = 0;
                }
            }
            if (longest == 1)
            {
                result = result / 2;
            }
            Console.WriteLine(longest);
            Console.WriteLine(result);
        }
    }
}
