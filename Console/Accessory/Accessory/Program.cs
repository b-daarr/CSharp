using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessory
{
    class Program
    {
        static void Main(string[] args)
        {
            int B = 0;
            bool G = false;

            while (G == false)
            {
                if (B < 18)
                {
                    Console.Clear();
                    G = false;
                    var F = Console.ReadLine();
                    int V = int.Parse(F);

                    if (V >= 18 && V < 99)
                    {
                        Console.Clear();
                        Console.WriteLine("You have {0} years old and Welcome!", V);
                        G = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Your Access denied...");
                        G = true;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
