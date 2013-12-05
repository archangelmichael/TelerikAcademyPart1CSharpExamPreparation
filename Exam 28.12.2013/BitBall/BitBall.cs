using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBall
{
    class BitBall
    {
        static void Main()
        {
            int n = 8;
            int[,] team1 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    int bit = (number >> j) & 1;
                    team1[i, j] = bit;
                }
            }
            
            int[,] team2 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    int bit = (number >> j) & 1;
                    team2[i, j] = bit;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (team1[i,j] == team2[i,j])
                    {
                        team1[i, j] = 0;
                        team2[i, j] = 0;
                    }
                    else if (team1[i,j] ==1 && team2 [i,j] == 0)
                    {
                        team2[i, j] = 2;
                    }
                    else if (team1[i, j] == 0 && team2[i, j] == 1)
                    {
                        team1[i, j] = 2;
                    }
                }
            }
            int team1score = 0;
            int team2score = 0;
            bool team1scores = false;
            bool team2scores = false;

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (team2[row,col] == 1)
                    {
                        team2score++;
                        break;
                    }
                    else if (team2[row,col] == 2)
                    {
                        break;
                    }
                }
                
                for (int row = n-1; row >= 0; row--)
                {
                    if (team1[row, col] == 1)
                    {
                        team1score++;
                        break;
                    }
                    else if (team1[row, col] == 2)
                    {
                        break;
                    }
                }
                if (team2scores)
                {
                    team2score++;
                    team2scores = false;
                }
            }
            Console.WriteLine(team1score + ":"+ team2score);
        }
    }
}
