using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelComuns
{
    class ExcelComuns
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[] input = new char [n];
            long current= 0;
            for (int i = 0; i < n; i++)
			{
			    input[i] = Convert.ToChar(Console.ReadLine());
                current = current + (input[i] - 64) * (long)Math.Pow(26, n - i - 1);
			}
            Console.WriteLine(current);
        }
    }
}
