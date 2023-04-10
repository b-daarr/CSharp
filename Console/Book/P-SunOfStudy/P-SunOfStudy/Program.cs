using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SunOfStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            var Minute = 0;

            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("Please rate the day {0} enter in minutes: ",i);
                Minute = int.Parse(Console.ReadLine());

                Sum = Sum + Minute;
            }
            Console.WriteLine("Your studied for {0} minutes a week ", Sum);

            Console.ReadKey();
        }
    }
}
