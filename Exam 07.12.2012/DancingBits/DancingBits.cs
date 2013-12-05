using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DancingBits
{
    class DancingBits
    {
        static void Main(string[] args)
        {
            int set = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());
            string concatenated = "";

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                string numberToString = Convert.ToString(number, 2);
                concatenated += numberToString;
                //Console.WriteLine(Convert.ToString(number,2));
                //Console.WriteLine(concatenated);
            }
            int count = 1;
            int dance = 0;
            byte settype = 1;
            for (int i = 1; i < concatenated.Length; i++)
            {
                if (concatenated[i] == '1' && settype == 1)
                {
                    count++;
                }
                else if (concatenated[i] == '1' && settype == 0)
                {
                    settype = 1;
                    if (count == set)
                    {
                        dance++;
                    }
                    count = 1;
                }
                else if (concatenated[i] == '0' && settype == 0)
                {
                    count++;
                }
                else if (concatenated[i] == '0' && settype == 1)
                {
                    settype = 0;
                    if (count == set)
                    {
                        dance++;
                    }
                    count = 1;
                }

            }
            if (count == set)
            {
                dance++;
            }
            Console.WriteLine(dance);
        }
    }
}