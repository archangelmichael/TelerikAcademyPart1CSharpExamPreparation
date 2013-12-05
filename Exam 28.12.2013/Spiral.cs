using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    class Spiral
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] spiral = new int[n, n];
            string direction = "right";
            int currentrow = 0;
            int currentcol = 0;
            for (int i = 1; i <= n *n; i++)
            {
                if (direction == "right" && (currentcol >= n || spiral [currentrow,currentcol] != 0))
                {
                    currentrow++;
                    currentcol--;
                    direction = "down";
                }
                if (direction == "down" && (currentrow >= n || spiral [currentrow,currentcol] != 0))
                {
                    currentrow--;
                    currentcol--;
                    direction = "left";
                }
                if (direction == "left" &&( currentcol < 0 || spiral [currentrow,currentcol] != 0))
                {
                    currentrow--;
                    currentcol++;
                    direction = "up";
                }
                if (direction == "up" && (currentrow < 0 || spiral [currentrow,currentcol] != 0 ))
                {
                    currentrow++;
                    currentcol++;
                    direction = "right";
                }

                spiral[currentrow, currentcol] = i ;
                if (direction == "right")
                {
                    currentcol++;
                }
                else if (direction == "down")
                {
                    currentrow++;
                }
                else if (direction == "left")
                {
                    currentcol--;
                }
                else if (direction == "up")
                {
                    currentrow--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((spiral[i, j].ToString().PadLeft(4,' ')));
                }
                Console.WriteLine();
            }
        }
    }
}
