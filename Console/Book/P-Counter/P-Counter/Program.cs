using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = false;

            for (int i = 100; i <= 999; i++)
            {
                Console.Write("   " + i);
            }

            Console.ReadKey();
        }
    }
}
