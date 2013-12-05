using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDamage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());
            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());
            int horizon = int.Parse(Console.ReadLine());
            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());
            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());
            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());
            //ship position
            
            // correction for horizon
            
            sy1 = sy1 - horizon;
            sy2 = sy2 - horizon;
            cy1 = horizon - cy1;
            cy2 = horizon - cy2;
            cy3 = horizon - cy3;

            int top = sy1 > sy2 ? sy1 : sy2;
            int bot = sy1 < sy2 ? sy1 : sy2;
            int left = sx1 < sx2 ? sx1 : sx2;
            int right = sx1 > sx2 ? sx1 : sx2;
            

            int damage = 0;
            int shots = 0;
            int x = cx1;
            int y = cy1;

            do
            {
                if ((x ==  left && y == top) || (x ==  left && y == bot)|| (x== right && y == top) || (x == right && y == bot))
                {
                    damage += 25;
                }
                else if (x <= right && x >= left && y >= bot && y <= top )
                {
                    if (x < right && x > left && y > bot && y < top)
                    {
                        damage += 100;
                    }
                    else
                    {
                        damage += 50;
                    }
                    
                }
                x = cx2;
                cx2 = cx3;
                y = cy2;
                cy2 = cy3;
                shots++;
                

            } while (shots<=2);
            
            Console.WriteLine(damage + "%");
        }
    }
}
