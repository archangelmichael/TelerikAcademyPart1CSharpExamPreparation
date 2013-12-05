using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAllLoveBits
{
    class WeAllLoveBits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] results = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                string start = Convert.ToString(number, 2);
                string point = "";
                string dpoint = "";
                for (int j = 0; j < start.Length; j++)
                {

                    dpoint += start[start.Length - j - 1];
                    if (start[j] == '0')
                    {
                        point += '1';
                    }
                    else
                    {
                        point += '0';
                    }
                }
                Console.WriteLine(start);
                Console.WriteLine(point);
                Console.WriteLine(dpoint);
                int one = Convert.ToInt32(start, 2);
                int two = Convert.ToInt32(point, 2);
                int three = Convert.ToInt32(dpoint, 2);
                Console.WriteLine(one);
                Console.WriteLine(two);
                Console.WriteLine(three);
                results[i] = ((one ^ two) & three);
                

            }
            for (int i = 0; i < n; i++)
			{
			    Console.WriteLine(results[i]);
			}
            
        }
    }
}
