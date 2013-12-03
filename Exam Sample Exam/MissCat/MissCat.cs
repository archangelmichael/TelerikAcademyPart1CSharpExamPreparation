using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            int[] cats = new int[10];
            int number = int.Parse(Console.ReadLine());
            int vote = 0;
            int winner = 0;
            int score = 0;
            while (number >0)
            {
                vote = int.Parse(Console.ReadLine()) - 1;
                cats[vote] = cats[vote] + 1;
                if (cats[vote] > score)


                {
                    score = cats[vote];
                    winner = vote +1;
                }
                number--;
            }
            Console.WriteLine(winner);
        }
    }
}
