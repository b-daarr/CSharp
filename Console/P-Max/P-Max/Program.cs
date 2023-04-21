using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour, min, max = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter 0 for start: ");
            hour = int.Parse(Console.ReadLine());
            hour = 1;

            while (hour > 0)
            {
                if (hour > max)
                {
                    max = hour;
                    Console.WriteLine("\nEnter 0 for Exit");
                    Console.Write("Enter hour: ");
                    hour = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("max: {0}", max);

            Console.ReadKey();
        }
    }
}
