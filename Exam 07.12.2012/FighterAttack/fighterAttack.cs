using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fighterAttack
{
    class fighterAttack
    {
        static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int f1 = int.Parse(Console.ReadLine());
            int f2 = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            //plant position
            
            // correction for horizon
            int top = y1 > y2 ? y1 : y2;
            int bot = y1 < y2 ? y1 : y2;
            int left = x1 < x2 ? x1 : x2;
            int right = x1 > x2 ? x1 : x2;
            int hor = f1 + distance;

            int damage = 0;
            int dotX = f1 + distance;
            int dotCenterY = f2; // 100%
            int dotUpY = f2 + 1; // 50%
            int dotDownY = f2 - 1; // 50%
            int dotRightY = f2; // x = dotsX + 1; -> 75%
            if (dotX >= left && dotX <= right)
            {
                if (dotCenterY >= bot && dotCenterY <= top)
                    damage += 100;

                if (dotUpY >= bot && dotUpY <= top)
                    damage += 50;

                if (dotDownY >= bot && dotDownY <= top)
                    damage += 50;
            }

            if (dotX + 1 >= left && dotX + 1 <= right)
            {
                if (dotRightY >= bot && dotRightY <= top)
                    damage += 75;
            }
            
            Console.WriteLine(damage + "%");
        }
    }
}
