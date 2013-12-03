using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDownWithArrays
{
    class FallDownWithArrays
    {
        static void Main(string[] args)
        {
            // solution with bit operations
            //input
            int[] nums = new int[8];
            for (int i = 0; i < 8; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            //body
            for (int j = 0; j < 8; j++)
            {
                for (int i = 7; i >= 1; i--)
                {
                    for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                    {
                        if (((nums[i] >> bitPosition) & 1) == 0 && ((nums[i - 1] >> bitPosition) & 1) == 1)
                        {
                            nums[i] |= (1 << bitPosition);
                            nums[i - 1] ^= (1 << bitPosition);   // or n6 &= -(1 << bitPosition);
                        }
                    }
                }
            }
            //output
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
