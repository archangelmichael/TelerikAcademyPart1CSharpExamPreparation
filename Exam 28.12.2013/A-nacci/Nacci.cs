using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacci
{
    class Nacci
    {
        static void Main(string[] args)
        {
            Dictionary<char, byte> nacci = new Dictionary<char, byte>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                nacci.Add(i, (byte)(i - 64));
            }

            char[] start = new char[2];
            start[0] = char.Parse(Console.ReadLine());
            start[1] = char.Parse(Console.ReadLine());
            byte number = byte.Parse(Console.ReadLine());
            byte spaces = 0;
            int rows = number;
            if (number >= 2)
            {
                rows = number * 2 - 1;
            }
            for (int i = 0; i < rows; i++)
            {
                if (i >= 2)
                {
                    int next = nacci[start[0]] + nacci[start[1]];
                    if (next > 26)
                    {
                        next = next % 26;
                    }
                    start[0] = start[1];
                    start[1] = nacci.ElementAt(next - 1).Key;
                    Console.Write(start[1]);
                    Console.Write(new string(' ', spaces));
                }
                else
                {
                    Console.Write(start[i]);
                    if (i == 0)
                    {
                        Console.WriteLine();
                    }
                }

                if (i > 0 && i % 2 == 0)
                {
                    Console.WriteLine();
                    spaces++;
                }
            }
        }
    }
}
