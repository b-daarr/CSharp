using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_MonthGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int Month, Guess = 0;
            int Score = 5;

            Console.Write("Enter number your month: ");
            Month = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Your guess? ");
                Guess = int.Parse(Console.ReadLine());

                if (Guess == Month)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You Win!");
                    Console.WriteLine("Your score: {0}", Score);
                    break;
                }
                else
                {
                    if (i < 5)
                    {
                        Score -= 1;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Not correct!\nTry again...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You lose!");
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
