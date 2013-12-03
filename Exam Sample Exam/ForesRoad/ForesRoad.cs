using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForesRoad
{
    class ForesRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int path = 0;
            int position = 0;
            char tree = '*';
            char grass = '.';
            bool turn = false;
            while (path < 2 * n - 1)
            {
                if (position == 0)
	            {
                    Console.Write(tree);
                    Console.Write(new string (grass, n - 1));
                    position++;
                    Console.WriteLine();
	            }
                else if (position > 0 && position < n - 1 && !turn)
                {
                    Console.Write(new string(grass,position));
                    Console.Write(tree);
                    Console.Write(new string(grass,n-position-1));
                    position++;
                    Console.WriteLine();
                }
                else if (position == n-1 )
                {
                    Console.Write(new string(grass, n - 1));
                    Console.Write(tree);
                    turn = true;
                    position--;
                    Console.WriteLine();
                }
                else if (turn && position > 0 && position < n - 1 )
                {
                    Console.Write(new string(grass, position));
                    Console.Write(tree);
                    Console.Write(new string(grass, n - position -1));
                    Console.WriteLine();
                    position--;
                }
                else
                {
                    Console.Write(tree);
                    Console.Write(new string(grass, n - 1));
                    Console.WriteLine();
                    break;
                }
                
                path++;
            }
        }
    }
}
