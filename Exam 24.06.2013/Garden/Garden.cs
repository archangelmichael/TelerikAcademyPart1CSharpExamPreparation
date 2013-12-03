using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            uint tomato = uint.Parse(Console.ReadLine());
            decimal tomatoPrice = tomato * 0.5m;
            uint tomatoArea = uint.Parse(Console.ReadLine());
 
            uint cucumber = uint.Parse(Console.ReadLine());
            decimal cucumberPrice = cucumber * 0.4m;
            uint cucumberArea = uint.Parse(Console.ReadLine());
           
            uint potato = uint.Parse(Console.ReadLine());
            decimal potatoPrice = potato * 0.25m;
            uint potatoArea = uint.Parse(Console.ReadLine()); 

            uint carrot = uint.Parse(Console.ReadLine());
            decimal carrotPrice = carrot * 0.6m;
            uint carrotArea = uint.Parse(Console.ReadLine()); 

            uint cabbage = uint.Parse(Console.ReadLine());
            decimal cabbagePrice = cabbage * 0.3m;
            uint cabbageArea = uint.Parse(Console.ReadLine()); 

            uint beans = uint.Parse(Console.ReadLine());
            decimal beansPrice = beans * 0.4m;

            decimal totalPrice = tomatoPrice+cucumberPrice+potatoPrice+carrotPrice+cabbagePrice+beansPrice;
            Console.WriteLine("Total costs: {0:F2}",totalPrice );

            uint allArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            
            if (allArea>250)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (allArea==250)
	        {
		        Console.WriteLine("No area for beans");
	        }
            else
            {
                Console.WriteLine("Beans area: {0}", 250-allArea);
            }
            
        }
    }
}
