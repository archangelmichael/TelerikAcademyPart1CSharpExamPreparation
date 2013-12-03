using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Carpets
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int count = 0;
            //Romb top
            for (int row = 0; row < (size/2); row++)
            {
                Console.Write(new string('.', size / 2 - row - 1));
                if (row == 0)
                {
                    Console.Write('/');
                    Console.Write('\\');
                }
                else if (row % 2 == 0 && row != 0)
                {
                    count = row / 2;
                    Console.Write('/');
                    while (count > 0)
                    {
                        Console.Write(' ');
                        Console.Write('/');
                        count--;
                    }
                    count = row / 2;
                    while (count > 0)
                    {
                        Console.Write('\\');
                        Console.Write(' ');
                        count--;
                    }
                    Console.Write('\\');
                }
                else 
                {
                    count = row / 2 + 1;
                    while (count > 0)
                    {
                        Console.Write('/');
                        Console.Write(' ');
                        count--;
                    }
                    count = row / 2 ;
                    while (count >= 0)
                    {
                        Console.Write(' ');
                        Console.Write('\\');
                        count--;
                    }
                }
                Console.Write(new string('.', size / 2 - row - 1));
                Console.WriteLine();
            }


            //bottom
            

            for (int row = 0; row < size / 2; row++)
            {
                Console.Write(new string('.', row));
                if (row == ((size / 2) - 1) )
                {
                    Console.Write('\\');
                    Console.Write('/');
                    
                }
                else if (row % 2 == 0 && row != ((size / 2) - 1) )
                {
                    if (size / 2 % 2 == 0)
                    {
                        count = (size / 2 - row) / 2;
                        while (count > 0)
                        {
                            Console.Write('\\');
                            Console.Write(' ');
                            count--;
                        }
                        count = (size / 2 - row) / 2;
                        while (count > 0)
                        {
                            Console.Write(' ');
                            Console.Write('/');
                            count--;
                        }
                    }
                    else
                    {
                        count = (size / 2 - row) / 2;
                        while (count > 0)
                        {
                            Console.Write('\\');
                            Console.Write(' ');
                            count--;
                        }
                        Console.Write('\\');
                        Console.Write('/');
                        count = (size / 2 - row) / 2;
                        while (count > 0)
                        {
                            Console.Write(' ');
                            Console.Write('/');
                            count--;
                        }
                    }
                    
                }
                else
                {
                    if (size / 2 % 2 == 0)
                    {
                        count = (size / 2 - row) / 2;
                        while (count > 0)
                        {
                            Console.Write('\\');
                            Console.Write(' ');
                            count--;
                        }
                        Console.Write('\\');
                        Console.Write('/');
                        count = (size / 2 - row) / 2 - 1;
                        while (count >= 0)
                        {
                            Console.Write(' ');
                            Console.Write('/');
                            count--;
                        }
                    }
                    else
                    {
                        count = (size / 2 - row) / 2;
                        while (count > 0)
                        {
                            Console.Write('\\');
                            Console.Write(' ');
                            count--;
                        }
                        count = (size / 2 - row) / 2 - 1;
                        while (count >= 0)
                        {
                            Console.Write(' ');
                            Console.Write('/');
                            count--;
                        }
                    }
                }
                Console.Write(new string('.', row));
                Console.WriteLine();
            }
        }
    }
}
