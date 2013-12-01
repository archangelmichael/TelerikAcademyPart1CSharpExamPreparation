using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bat_GojkoTower
{
    class BatGojkoTower
    {
        static void Main(string[] args)
        {
            int height = 0;
            int count = 1;
            int move = 2;
            do
            {
                height = int.Parse(Console.ReadLine());
            } while (height <2 || height > 39);
            
            for (int row = 0; row < height; row++)
            {
                
                Console.Write(new string('.', height - row - 1));
                Console.Write('/');
                if (count == row)
                {
                    Console.Write(new string('-', row * 2));
                    count += move++;
                    
                }
                else
                {
                    Console.Write(new string('.', row * 2));
                }

                
                Console.Write('\\');
                Console.Write(new string('.', height - row - 1));
                Console.WriteLine();
                
                
            }
            
        }
    }
}
