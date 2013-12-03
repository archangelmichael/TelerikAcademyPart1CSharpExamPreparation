using System;
using System.Linq;

class Bittris
{
    static void Main()
    {
        const int Rows = 4;
        const int Cols = 8;
        int numberN = int.Parse(Console.ReadLine());
        // dont need first row, if the game is running
        uint row1 = 0;
        uint row2 = 0;
        uint row3 = 0;
        int score = 0;
        int current = 0;
        while (true)
        {
            current++;
            if (current > numberN)
            {
                Console.WriteLine(score);
                break;
            }
            uint number;
            if (!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(score);
                return;
            }
            string controls = Console.ReadLine() + Console.ReadLine() + Console.ReadLine();
            int scoreweight = 0;
            for (int i = 0; i < 32; i++)
            {
                if ( (number & (1<<i)) != 0 )
                {
                    scoreweight += 1;
                }
            }
            const uint Bit = (uint)1;
            const uint MaskTopBit = Bit << (Cols - 1);
            const uint MaskLowBit = Bit;
            const uint Mask8Bits = (Bit << Cols) - 1;

            uint shape = number & Mask8Bits;
            // move down
            for (int currentRow = 0; currentRow < Rows; currentRow++)
            {
                if (currentRow < 3)
                {
                    char ctrl = controls[currentRow];
                    if (ctrl == 'L')
                    {
                        if ((shape & MaskTopBit) == 0 )
                        {
                             shape <<= 1;
                        }
                       
                    }
                    else if (ctrl == 'R')
                    {
                        if ((shape & MaskLowBit) == 0)
                        {
                            shape >>= 1;
                        }
                    }
                }

                int nextRow = currentRow + 1;
                uint nextRowBits = 0;
                switch (nextRow)
                {
                    case 1: nextRowBits = row1;
                        break;
                    case 2: nextRowBits = row2;
                        break;
                    case 3: nextRowBits = row3;
                        break;
                }
                if (nextRow == Rows || (nextRowBits & shape) !=0)
                {
                    switch (currentRow)
                    {
                        case 1: row1 |= shape; break;
                        case 2: row2 |= shape; break;
                        case 3: row3 |= shape; break;
                    }
                    bool isRowFull = false;
                    switch (currentRow)
                    {
                        case 0: isRowFull = (shape == Mask8Bits); break;
                        case 1: isRowFull = (row1 == Mask8Bits); break;
                        case 2: isRowFull = (row2 == Mask8Bits); break;
                        case 3: isRowFull = (row3 == Mask8Bits); break;
                    }
                    if (isRowFull)
                    {
                        score += scoreweight * 10;
                        for (int i = currentRow; i >= 1; i--)
                        {
                            switch (i)
                            {
                                case 1: row1 = 0; break;
                                case 2: row2 = row1; break;
                                case 3: row3 = row2; break;
                            }
                        }
                    }
                    else
                    {
                        score += scoreweight;
                    }
                    if (currentRow == 0 && !isRowFull)
                    {
                        Console.WriteLine(score);
                        return;
                    }
                    break;
                }
            }
        }
    }
}