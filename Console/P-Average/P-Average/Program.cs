using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            string stuName = "";
            float sum = 0, avg;
            int count = 0;

            Console.Write("Enter mark {0}: ", count + 1);
            float mark = float.Parse(Console.ReadLine());

            while (mark >= 0)
            {
                sum = sum + mark;
                count++;
                Console.Write("Enter mark {0}: ", count + 1);
                mark = float.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
