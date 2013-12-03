using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBit
{
    class FormulaBit
    {
        static void Main(string[] args)
        {
            int rows = 8;
            int columns = 8;
            bool[,] track = new bool[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < columns; j++)
                {
                    track[i, j] = ((number >> j) & 1) != 0;
                }
            }
            int row = 0;
            int col = 0;

            int path = 0;
            int directions = 0;

            bool exit = false;

            string direction = "down";
            string lastDirection = "down";

            while (true)
            {
                if (track[row, col])
                {
                    break;
                }

                path += 1;

                if (row == 7 && col == 7)
                {
                    exit = true;
                    break;
                }
                if (direction == "down" && (row + 1 > 7 || track [row + 1, col]) )
                {
                    direction = "left";
                    lastDirection = "down";
                    directions++;

                    if (col +1 > 7 || track[row, col + 1])
                    {
                        break;
                    }
                }
                else if (direction == "up" && (row -1 < 0 || track [row - 1, col]))
                {
                    direction = "left";
                    lastDirection = "up";
                    directions++;
                    if (col + 1 > 7 || track[row,col + 1])
                    {
                        break;
                    }
                }
                else if (direction == "left" && lastDirection == "down" && (col +1 > 7 || track[row, col +1]) )
                {
                    direction = "up";
                    directions++;
                    if (row - 1 < 0 || track[row - 1, col])
                    {
                        break;
                    }
                }
                else if (direction == "left" && lastDirection == "up" && (col + 1 > 7 || track[row, col + 1]))
                {
                    direction = "down";
                    directions++;
                    if (row + 1 >= 7 || track[row + 1, col])
                    {
                        break;
                    }
                }
                if (direction == "down")
                {
                    row++;
                }
                else if (direction == "up")
                {
                    row--;
                }
                else if (direction == "left")
                {
                    col++;
                }

            }

            if (exit)
            {
                Console.WriteLine(path + " " + directions);
            }
            else if (track[0, columns - 1])
            {
                Console.WriteLine("No");
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("No " + path);
            }
        }
    }
}
