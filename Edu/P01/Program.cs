using System.Runtime.InteropServices.Marshalling;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("New Line \n");
            Console.WriteLine("Return \r");
            Console.WriteLine("Tab \t");
            Console.WriteLine("Backspace \b");
            Console.WriteLine("Double quote \" ");
            Console.WriteLine("quote \' ");
            Console.WriteLine("Backslash \\ ");

            // Variables
            byte by = 0;
            sbyte sby = 0;
            short sh = 0;
            ushort ush = 0;
            int i = 0;
            nint ni = 0;
            uint ui = 0;
            nuint nui = 0;
            long l = 0;
            ulong ul = 0;
            float f = 0.0f;
            double d = 0.0;
            bool b = false;
            char c = 'a';
            string s = null;
            var v = 0;
            dynamic sy = null;
            const dynamic co = null;
            // array
            int[] ArrayVar = { };
            
            Console.WriteLine("Number is {0}", l + s);

            Console.ReadKey();
        }
    }
}
