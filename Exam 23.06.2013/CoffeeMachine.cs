using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            int coin5Count = int.Parse(Console.ReadLine());
            int coin10Count = int.Parse(Console.ReadLine());
            int coin20Count = int.Parse(Console.ReadLine());
            int coin50Count = int.Parse(Console.ReadLine());
            int coin100Count = int.Parse(Console.ReadLine());
            decimal inputMoney = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            decimal changeMoney = inputMoney - price;
            if (changeMoney <0 )
            {
                Console.WriteLine("More {0:F2}", - changeMoney);
            }
            else
            {
                decimal machineMoney = 0.05M * coin5Count 
                                    + 0.10M * coin10Count 
                                    + 0.20M * coin20Count 
                                    + 0.50M * coin50Count 
                                    + 1.00M * coin100Count;
                if (machineMoney >= changeMoney)
                {
                    //second case - enough money for change
                    Console.WriteLine("Yes {0:F2}", machineMoney- changeMoney);
                }
                else
                {
                    //third case - not enough money for change
                    Console.WriteLine("No {0:F2}", changeMoney - machineMoney);
                }
            }
        }
    }
}
