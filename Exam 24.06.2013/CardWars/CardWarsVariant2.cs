using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CardWarsVariant2
{
    class CardWarsVariant2
    {
        static void Main(string[] args)
        {
            // using switch case
            checked
            {
                int allGames = int.Parse(Console.ReadLine());
                const int cardsPerGame = 3;
                BigInteger globalScore1 = 0;
                BigInteger globalScore2 = 0;
                bool firstX = false;
                bool secondX = false;
                int wonFirst = 0;
                int wonSecond = 0;
                for (int i = 0; i < allGames; i++)
                {
                    int localScore1 = 0;
                    int localScore2 = 0;
                    for (int j = 0; j < cardsPerGame; j++)
                    {
                        string card = Console.ReadLine();
                        switch (card)
                        {
                            case "J": localScore1 += 11;
                                break;
                            case "Q": localScore1 += 12;
                                break;
                            case "K": localScore1 += 13;
                                break;
                            case "A": localScore1 += 1;
                                break;
                            case "X": firstX = true;
                                break;
                            case "Y": globalScore1 -= 200;
                                break;
                            case "Z": globalScore1 *= 2;
                                break;
                            default: localScore1 += 12 - int.Parse(card);
                                break;
                        }
                    }
                    for (int j = 0; j < cardsPerGame; j++)
                    {
                        string card = Console.ReadLine();
                        switch (card)
                        {
                            case "J": localScore2 += 11;
                                break;
                            case "Q": localScore2 += 12;
                                break;
                            case "K": localScore2 += 13;
                                break;
                            case "A": localScore2 += 1;
                                break;
                            case "X": secondX = true;
                                break;
                            case "Y": globalScore2 -= 200;
                                break;
                            case "Z": globalScore2 *= 2;
                                break;
                            default: localScore2 += 12 - int.Parse(card);
                                break;
                        }
                    }
                    if (firstX && secondX)
                    {
                        globalScore1 += 50;
                        globalScore2 += 50;
                        firstX = false;
                        secondX = false;
                    }
                    else if (firstX)
                    {
                        break;
                    }
                    else if (secondX)
                    {
                        break;
                    }
                    if (localScore1 > localScore2)
                    {
                        globalScore1 += localScore1;
                        wonFirst++;
                    }
                    else if (localScore1 < localScore2)
                    {
                        globalScore2 += localScore2;
                        wonSecond++;
                    }
                }
                if (firstX)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                }
                else if (secondX)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                }
                if (globalScore1 > globalScore2)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: {0}", globalScore1);
                    Console.WriteLine("Games won: {0}", wonFirst);
                }
                else if (globalScore1 < globalScore2)
                {
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: {0}", globalScore2);
                    Console.WriteLine("Games won: {0}", wonSecond);
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Score: {0}", globalScore1);
                }
            }
        }
    }
}
