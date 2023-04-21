using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i+=2)
            {
                Console.Write("  " + i);
            }

            Console.Write("\n");

            for (int a = 0; a <= 30; a++)
            {
                a++;
                Console.Write("  " + a);
            }

            Console.ReadKey();
        }
    }
}
