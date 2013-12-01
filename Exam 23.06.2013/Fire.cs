using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Fire
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            //Fire top
            int count = 0;
            int torchtop = width / 2;

            for (int row = 0; row < torchtop; row++)
            {
                Console.Write(new string('.', torchtop - row -1));
                Console.Write('#');
                Console.Write(new string('.', row*2));
                Console.Write('#');
                Console.Write(new string('.', torchtop - row -1));
                Console.WriteLine();
            }

            //Fire bottom
            int torchend = width / 4;
            for (int row = 0; row < torchend; row++)
            {
                Console.Write(new string('.', row));
                Console.Write('#');
                Console.Write(new string('.',(width - 2*row)-2 ));
                Console.Write('#');
                Console.Write(new string('.', row));
                Console.WriteLine();
            }

            //Torch midline
            Console.Write(new string('-', width));
            Console.WriteLine();
            
            //Torch handle
            int handlerows = width / 2;
            for (int row = 0; row < handlerows; row++)
            {
                Console.Write(new string('.', row));
                Console.Write(new string('\\', handlerows - row));
                Console.Write(new string('/', handlerows - row));
                Console.Write(new string('.', row));
                Console.WriteLine();
            }
        }
    }
}
