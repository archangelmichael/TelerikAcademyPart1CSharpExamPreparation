using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal result = 0;
            decimal sin = (decimal)Math.Sin((int)m % 180);
            result = (n * n + 1 / (m * p) + 1337) / (n - 128.523123123m * p) + sin;
            Console.WriteLine("{0:F6}", result);
        }
    }
}
