using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            float jackpot = 1000000;
            Console.WriteLine("Welcome to the $" + jackpot + " Lucky Numbers Game!");
            string action = " ";
            do
            {
                Console.WriteLine("Please enter a number that will represent the lowest number in the Lucky Numbers range of numbers");
                int lowEnd = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number that will represent the highest number in the Lucky Numbers range of number");
                int highEnd = int.Parse(Console.ReadLine());

                int[] userNumbers = new int[6];

                for (int i = 0; i < userNumbers.Length; i++)
                {
                    Console.WriteLine("Please enter a number between " + lowEnd + " and " + highEnd);
                    userNumbers[i] = int.Parse(Console.ReadLine());

                    for (int j = 0; j < i; j++)
                    {
                        if ((userNumbers[i] >= lowEnd) && (userNumbers[i] <= highEnd))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number that is ACTUALLY between " + lowEnd + " and " + highEnd);
                            userNumbers[i] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                Random r = new Random();
                int[] rArray = new int[6];
                for (int i = 0; i < rArray.Length; i++)
                {
                    rArray[i] = r.Next(lowEnd, highEnd);
                    Console.WriteLine("Lucky Number: " + rArray[i]);
                }

                int numbersHit = 0;
                for (int i = 0; i < userNumbers.Length; i++)
                {
                    for (int j = 0; j < rArray.Length; j++)
                    {
                        if (userNumbers[i] == rArray[j])
                        {
                            numbersHit++;
                            
                        }
                        
                    }
                    
                }
                Console.WriteLine("You guessed " + numbersHit + " correctly!!!");


                //int[] hitNumbers2 = new int[6];
                //int numbersCorrect = hitNumbers2[0] + hitNumbers2[1] + hitNumbers2[2] + hitNumbers2[3] + hitNumbers2[4] + hitNumbers2[5];

                double winnings;
                if (numbersHit == 0)
                {
                    winnings = (0 * jackpot);
                    Console.WriteLine("You won $" + winnings + "!!!!!!!!!!");
                }
                if (numbersHit == 1)
                {
                    winnings = (0.03175 * jackpot);
                    Console.WriteLine("You won $" + winnings + "!!!!!!!!!!");
                }
                if (numbersHit == 2)
                {
                    winnings = (0.0625 * jackpot);
                    Console.WriteLine("You won $" + winnings + "!!!!!!!!!!");
                }
                if (numbersHit == 3)
                {
                    winnings = (0.125 * jackpot);
                    Console.WriteLine("You won $" + winnings + "!!!!!!!!!!");
                }
                if (numbersHit == 4)
                {
                    winnings = (0.25 * jackpot);
                    Console.WriteLine("You won $" + winnings + "!!!!!!!!!!");
                }
                if (numbersHit == 5)
                {
                    winnings = (0.5 * jackpot);
                    Console.WriteLine("You won $" + winnings + "!!!!!!!!!!");
                }
                if (numbersHit == 6)
                {
                    winnings = (1 * jackpot);
                    Console.WriteLine("You won $" + winnings + "!!!!!!!!!!");
                }
                Console.WriteLine("Do you want to play again. Type YES or NO");
                action = Console.ReadLine().ToUpper();
                if (action == "NO")
                {
                    Console.WriteLine("Thanks for playing!");
                }
            } while (action == "YES");   
        }
    }
}
